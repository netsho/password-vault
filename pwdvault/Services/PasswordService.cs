/*
Netsho - Implements passwords functionalities. 
Copyright (C) 2023-2024 Netsho

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program. If not, see <https://www.gnu.org/licenses/>.
*/
using CsvHelper;
using CsvHelper.Configuration;
using pwdvault.Controllers;
using pwdvault.Models;
using Serilog;
using System.Collections;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using pwdvault.Services.Exceptions;

namespace pwdvault.Services
{
    public static class PasswordService
    {
        /// <summary>
        /// <para>
        /// Generates a password of fixed length : 20 characters. It uses RandomNumberGenerator to generate a sequence of random bytes, which are used to select random characters from the validChars string.
        /// </para>
        /// </summary>
        /// <returns>The method returns a string that contains the random characters.</returns>
        public static string GeneratePassword()
        {
            try
            {
                const int length = 20;
                const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$€%^&*()_+-=[]{}|;:,.<>?";

                var byteArray = new byte[length * 4];
                var randomNumberGenerator = RandomNumberGenerator.Create();
                randomNumberGenerator.GetBytes(byteArray);

                var stringBuilder = new StringBuilder(length);
                for (int i = 0; i < length; i++)
                {
                    uint randomInt = BitConverter.ToUInt32(byteArray, i * 4);
                    int randomIndex = (int)(randomInt % validChars.Length);

                    stringBuilder.Append(validChars[randomIndex]);
                }

                return stringBuilder.ToString();
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, "Source : {Source}, Message : {Message}\n {StackTrace}", ex.Source, ex.Message, ex.StackTrace);
                throw new PasswordException(ex.Message, ex);
            }
        }


        /// <summary>
        /// Defines regular expressions to check if the password is strong by meeting the criteria : At least 12 characters and at least 1 lowercase, 1 uppercase letter, 1 number and 1 special character.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        #pragma warning disable SYSLIB1045 // Convert to 'GeneratedRegexAttribute'.
        public static bool IsPasswordStrong(string password)
        {
            // Minimum length of 12 characters
            var lengthRegex = new Regex(".{12,}$");
            // Uppercase letter
            var upperRegex = new Regex("[A-Z]");
            // Lowercase letter
            var lowerRegex = new Regex("[a-z]");
            // Number
            var numberRegex = new Regex(@"\d");
            // Special character
            var characterRegex = new Regex(@"[!@#$€%^&*()_+\-=[\]{}\|;:,.<>?]");

            // Checks password against each regular expression
            var hasLength = lengthRegex.IsMatch(password);
            var hasUpper = upperRegex.IsMatch(password);
            var hasLower = lowerRegex.IsMatch(password);
            var hasNumber = numberRegex.IsMatch(password);
            var hasSpecialCharacter = characterRegex.IsMatch(password);

            // Return true if password meets all criteria
            return hasLength && hasUpper && hasLower && hasNumber && hasSpecialCharacter;
        }

        /// <summary>
        /// <para>
        /// Gets the icon name from the resource manager based on the app name the user typed, by checking for the exact match, if not found, checking for partial match.
        /// The Properties.Resources property represents the default resource file for the project, which is Resources.resx. 
        /// The ResourceManager property of this object allows access to the resource manager, which is responsible for retrieving resources from the resource file.
        /// The GetResourceSet method of the resource manager returns a ResourceSet object that contains all the resources in the specified culture and assembly.
        /// The System.Globalization.CultureInfo.CurrentCulture parameter specifies the culture to use when retrieving resources (in this case, the current culture of the application). 
        /// The true parameters indicate that the method should look for resources in the satellite assemblies and use the resource fallback process if a resource is not found for the specified culture.
        /// </para>
        /// </summary>
        /// <param name="appName"></param>
        /// <returns></returns>
        public static string GetIconName(string appName)
        {
            try
            {
                var resources = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);
                string appNameLower = appName.ToLower();
                string? partialMatch = null;
                if (resources == null) return "icons8_application";
                
                foreach (DictionaryEntry resource in resources)
                {
                    var resourceName = resource.Key.ToString()!.ToLower();

                    // Check for exact match first
                    if (resourceName.Replace("_", " ") == appNameLower)
                    {
                        return resourceName;
                    }

                    // Check for partial match
                    if (resourceName.Contains(appNameLower.Split(' ')[0]) && (partialMatch == null || resourceName.Length < partialMatch.Length))
                    { 
                        partialMatch = resourceName;
                    }
                }

                // Return the best match found, or default if no matches
                return partialMatch ?? "icons8_application";
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, "Source : {Source}, Message : {Message}\n {StackTrace}", ex.Source, ex.Message, ex.StackTrace);
                return string.Empty;
            }
        }

        /// <summary>
        /// Exports all the passwords from the database to the CSV file located in the AppData/Local/PasswordVault.
        /// </summary>
        /// <param name="passwords"></param>
        public static void ExportPasswords(List<AppPassword> passwords, string exportFolderPath)
        {
            // Decrypt all passwords
            var vaultController = VaultController.GetInstance();

            var passwordExports = passwords.Select(p => new ExportImportData(
                p.AppCategory, 
                p.AppName,
                p.UserName,
                EncryptionService.DecryptPassword(p.Password, vaultController.GetEncryptionKey(p.AppName, p.UserName), p.Bytes)
                )).ToList();

            // Define CSV file name
            const string csvName = "pwdvault_export.csv";

            // Write to CSV file
            using var writer = new StreamWriter($"{exportFolderPath}\\{csvName}");
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(passwordExports);
        }

        /// <summary>
        /// Imports all the passwords from the chosen CSV file and stores them in the database, along with their encryption keys. 
        /// </summary>
        /// <param name="csvPasswordsFile"></param>
        public static async Task ImportPasswords(string csvPasswordsFile)
        {
            // Read the CSV file
            using var reader = new StreamReader(csvPasswordsFile);
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ",", // Enforce ',' as delimiter
                PrepareHeaderForMatch = header => header.Header.ToLower() // Ignore casing
            };
            using var csv = new CsvReader(reader, config);
            var importedPasswordsCsv = csv.GetRecords<ExportImportData>().ToList();

            // Initialising the contexts to store the passwords in DB and encryption keys in vault
            await using var context = new PasswordVaultContext();
            var passwordController = new PasswordController(context);
            var vaultController = VaultController.GetInstance();

            // Store all the passwords in the database and their corresponding encryption keys
            foreach (var passwordCsv in importedPasswordsCsv)
            {
                byte[] encryptionKey = EncryptionService.GenerateKey(passwordCsv.Password);
                var password = new AppPassword(passwordCsv.AppCategory, passwordCsv.AppName, passwordCsv.UserName, EncryptionService.EncryptPassword(passwordCsv.Password, encryptionKey, out byte[] iv), GetIconName(passwordCsv.AppName), iv) { CreationTime = DateTime.Now, UpdateTime = DateTime.Now };
                passwordController.CreatePassword(password);
                await vaultController.StoreEncryptionKey(password.AppName, password.UserName, encryptionKey);
            }
        }
    }
}
