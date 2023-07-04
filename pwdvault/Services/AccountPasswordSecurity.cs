using System.Security.Cryptography;

namespace pwdvault.Services
{
    internal class AccountPasswordSecurity
    {
        private const int SaltSize = 32; // 256 bit
        private const int HashSize = 64; // 256 bit
        private const int Iterations = 100000;

        public static byte[] GenerateSalt()
        {
            var salt = new byte[SaltSize];
            using RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
            randomNumberGenerator.GetBytes(salt);
            return salt;
        }

        public static byte[] GenerateHash(string password, byte[] salt)
        {
            using Rfc2898DeriveBytes rfc2898 = new(password, salt, Iterations, HashAlgorithmName.SHA512);
            return rfc2898.GetBytes(HashSize);
        }

        public static bool VerifyPassword(string password, byte[] salt, byte[] hash)
        {
            var testHash = GenerateHash(password, salt);
            return SlowEquals(hash, testHash);
        }

        private static bool SlowEquals(byte[] a, byte[] b)
        {
            var diff = (uint)a.Length ^ (uint)b.Length;
            for (var i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }

            return diff == 0;
        }
    }
}
