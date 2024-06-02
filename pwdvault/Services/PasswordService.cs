/*
Netsho - Implements passwords functionalities. 
Copyright (C) 2023 Netsho

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
using pwdvault.Controllers;
using pwdvault.Forms;
using pwdvault.Modeles;
using Serilog;
using System.Collections;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace pwdvault.Services
{
    public class PasswordService
    {
        /// <summary>
        /// <para>
        /// Function that generate a password of fixed length : 20 characters. It uses RandomNumberGenerator to generate a sequence of random bytes,
        /// which are used to selectrandom characters from the validchars string.
        /// </para>
        /// </summary>
        /// <returns>The method returns a string that containes the random characters.</returns>
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
                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
                throw new Exception(ex.Message, ex);
            }
        }


        /// <summary>
        /// Function that defines regular expressions to check if the password is strong by meeting the criteria : At least 16 characters and at least 1 lowercase, 1 uppercase letter, 1 number and 1 special character.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        #pragma warning disable SYSLIB1045 // Convert to 'GeneratedRegexAttribute'.
        public static bool IsPasswordStrong(string password)
        {
            // Minimum length of 16 characters
            var lengthRegex = new Regex(@".{12,}$");
            // Uppercase letter
            var upperRegex = new Regex(@"[A-Z]");
            // Lowercase letter
            var lowerRegex = new Regex(@"[a-z]");
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
        /// Get the icon name from the resource manager based on the app name the user typed (The first part of the app name before 'space').
        /// The Properties.Resources property represents the default resource file for the project, which is Resources.resx. 
        /// The ResourceManager property of this object allows access to the resource manager, which is responsible for retrieving resources from the resource file.
        /// The GetResourceSet method of the resource manager returns a ResourceSet object that contains all of the resources in the specified culture and assembly.
        /// The System.Globalization.CultureInfo.CurrentCulture parameter specifies the culture to use when retrieving resources (in this case, the current culture of the application). 
        /// The true parameters indicate that the method should look for resources in the satellite assemblies and use the resource fallback process if a resource is not found for the specified culture.
        /// </para>
        /// </summary>
        /// <param name="AppName"></param>
        /// <returns></returns>
        public static string GetIconName(string AppName)
        {
            try
            {
                var resources = Properties.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, true, true);
                if (resources != null)
                {
                    foreach (var resource in resources)
                    {
                        var resourceName = ((DictionaryEntry)resource).Key.ToString()!;
                        if (resourceName.Contains(AppName.Split(' ')[0].ToLower()))
                        {
                            return resourceName;
                        }
                    }
                }
                return "icons8_image_48";
            }
            catch (Exception ex)
            {
                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
                return String.Empty;
            }
        }

        /// <summary>
        /// Function that export all the passwords in the database to a CSV file located in the AppData/Local/PasswordVault. The CSV file name contains the actual date.
        /// </summary>
        /// <param name="passwords"></param>
        public static void ExportPasswords(List<AppPassword> passwords)
        {
            // Decrypt all passwords
            var vaultController = VaultController.GetInstance();

            var passwordExports = passwords.Select(p => new ExportImportData
            (p.AppCategory, 
            p.AppName,
            p.UserName,
            EncryptionService.DecryptPassword(p.Password, vaultController.GetEncryptionKey(p.AppName, p.UserName), p.Bytes),
            p.IconName
            )).ToList();

            // Define CSV file + location
            string csvName = $"pwdvault_export.csv";
            var passwordVaultFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordVault");

            // Write to CSV file
            using var writer = new StreamWriter($"{passwordVaultFolder}\\{csvName}");
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(passwordExports);
        }
    }
}
