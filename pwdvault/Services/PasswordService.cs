using Serilog;
using System.Collections;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace pwdvault.Services
{
    internal class PasswordService
    {
        /// <summary>
        /// <para>
        /// Method that generate a password of fixed length : 20 characters. It uses RandomNumberGenerator to generate a sequence of random bytes,
        /// which are used to selectrandom characters from the validchars string.
        /// </para>
        /// </summary>
        /// <returns>The method returns a string that containes the random characters.</returns>
        public static string GeneratePassword()
        {
            const int length = 20;
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=[]{}|;:,.<>?";

            byte[] byteArray = new byte[length * 4];
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            rng.GetBytes(byteArray);


            StringBuilder sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                uint randomInt = BitConverter.ToUInt32(byteArray, i * 4);
                int randomIndex = (int)(randomInt % validChars.Length);

                sb.Append(validChars[randomIndex]);
            }

            return sb.ToString();
        }


        /// <summary>
        /// Function that defines regular expressions to check if the password is strong by meeting the criteria : At least 1 lowercase, 1 uppercase letter, 1 number and 1 special character.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool IsPasswordStrong(string password)
        {
            // Minimum length of 16 characters
            Regex lengthRegex = new Regex(@".{16,}$");
            // Uppercase letter
            Regex upperRegex = new Regex(@"[A-Z]");
            // Lowercase letter
            Regex lowerRegex = new Regex(@"[a-z]");
            // Number
            Regex numberRegex = new Regex(@"\d");
            // Special character
            Regex characterRegex = new Regex(@"[!@#$%^&*()_+\-=[\]{}\|;:,.<>?]");

            // Checks password against each regular expression
            bool hasLength = lengthRegex.IsMatch(password);
            bool hasUpper = upperRegex.IsMatch(password);
            bool hasLower = lowerRegex.IsMatch(password);
            bool hasNumber = numberRegex.IsMatch(password);
            bool hasSpecialCharacter = characterRegex.IsMatch(password);

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
                        string resourceName = ((DictionaryEntry)resource).Key.ToString()!;
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
                Log.Logger.Error("\nSource : " + ex.Source + "\nMessage : " + ex.Message);
                return String.Empty;
            }


        }
    }
}
