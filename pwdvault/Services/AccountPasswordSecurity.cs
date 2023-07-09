using Konscious.Security.Cryptography;
using Serilog;
using System.Security.Cryptography;
using System.Text;

namespace pwdvault.Services
{
    internal class AccountPasswordSecurity
    {
        private const int SALT_SIZE = 32; // 256 bit
        private const int HASH_SIZE = 32; // 256 bit
        private const int ITERATIONS = 4; // Recommanded minimum value
        private const int MEMORY_SIZE = 512000; // 512 MB

        public static byte[] GenerateSalt()
        {
            var salt = new byte[SALT_SIZE];
            using RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
            randomNumberGenerator.GetBytes(salt);
            return salt;
        }

        /// <summary>
        /// Generating hash for user's password using Argon2id algorithm to minimize brute force and side channel attacks.
        /// The parameters affecting security and performance of Argon2id hash algorithm are number of parallelism, iterations and memory size.
        /// Degree of parallelism is equal to number of CPU Cores * 2, which is the specification of Argon2id.
        /// To know what iterations and memory size to use, benchmarking and testing needs to be done to get the amount of time used to compute the hash.
        /// The time used for the hashing should not be lower than 0,5 seconds and not greater than 5 seconds.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public static byte[] GenerateHash(string password, byte[] salt)
        {
            using var argon2id = new Argon2id(Encoding.UTF8.GetBytes(password));
            argon2id.Salt = salt;
            // Number of CPU Cores x2
            argon2id.DegreeOfParallelism = Environment.ProcessorCount * 2;
            argon2id.Iterations = ITERATIONS;
            argon2id.MemorySize = MEMORY_SIZE;
            return argon2id.GetBytes(HASH_SIZE);
        }

        public static bool VerifyPassword(string password, byte[] salt, byte[] hash)
        {
            Log.Logger.Information("User's password verification...");
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
