using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace pwdvault.Services
{
    internal class PasswordService
    {

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
    }
}
