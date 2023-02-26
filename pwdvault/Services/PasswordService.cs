using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
    }
}
