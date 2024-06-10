/*
Netsho - Implements CRUD methods for managing encryption keys in vault. 
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
using VaultSharp;
using VaultSharp.V1.AuthMethods;
using VaultSharp.V1.AuthMethods.AppRole;
using Serilog;

namespace pwdvault.Controllers
{
    public sealed class VaultController
    {
        private readonly IVaultClient? _vaultClient;
        private readonly string _secretPath;
        private const string MOUNT_POINT = "secret";
        private const string DATA_KEY = "encryption_key";

        /// <summary>
        /// Locks object that will be used to synchronize threads during first access to the Singleton.
        /// </summary>
        private static readonly object _lock = new();
        private static VaultController? _instance;

        private VaultController(string roleID, string secretID, string vaultServerUri, string secretPath)
        {
            IAuthMethodInfo authMethodInfo = new AppRoleAuthMethodInfo(roleID, secretID);
            var vaultClientSettings = new VaultClientSettings(vaultServerUri, authMethodInfo);

            _vaultClient = new VaultClient(vaultClientSettings);
            _vaultClient.V1.Auth.PerformImmediateLogin();

            _secretPath = secretPath;
        }

        /// <summary>
        /// Singleton implementation to have only one connection to Vault server.
        /// This pattern implementation is safe in multithread environment with a lazy initialization for the singleton objet and a double check lock.
        /// The first condition is needed to prevent threads stumbling over the lock once the instance is ready.
        /// The "lock" will be granted to only one thread, thus creating the VaultController instance while the others would be waiting for the lock to be released.
        /// Once released, the thread that might have been waiting for the lock may get it this time. But since the VaultController is already initialized, the thread won't create a new VaultController. 
        /// </summary>
        /// <param name="roleID"></param>
        /// <param name="secretID"></param>
        /// <param name="vaultServerUri"></param>
        /// <returns></returns>
        public static VaultController GetInstance(string roleID, string secretID, string vaultServerUri, string secretPath)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new VaultController(roleID, secretID, vaultServerUri, secretPath);
                }
            }
            return _instance;
        }

        /// <summary>
        /// Gets the instance without providing parameters.
        /// If the instance is not already initialized, an exception is thrown.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static VaultController GetInstance()
        {
            if (_instance == null)
            {
                throw new Exception("VaultController instance has not been created.");
            }
            return _instance;
        }

        /// <summary>
        /// Stores the encryption key at the specified location: /secretPath/appName.
        /// The checkAndSet parameter in WriteSecretAsync is set to 0 so the write is only allowed if the encryption key doesn't exist.
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="encryptionKey"></param>
        public async void StoreEncryptionKey(string appName, string username, byte[] encryptionKey)
        {
            try
            {
                var encodedKey = Convert.ToBase64String(encryptionKey);
                var secret = new Dictionary<string, string>
                {
                    { DATA_KEY, encodedKey }
                };
                await _vaultClient!.V1.Secrets.KeyValue.V2.WriteSecretAsync($"{_secretPath}/{appName}/{username}", secret, 0, MOUNT_POINT);
            }
            catch (Exception ex)
            {
                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
                throw new Exception(ex.Message, ex);
            }
            
        }

        /// <summary>
        /// Gets the encryption key at the specified location: /secretpath/appName.
        /// </summary>
        /// <param name="appName"></param>
        /// <returns></returns>
        public byte[] GetEncryptionKey(string appName, string username)
        {
            var encryptionKey = Array.Empty<byte>();
            try
            {
                var kv2Secret = _vaultClient!.V1.Secrets.KeyValue.V2.ReadSecretAsync($"{_secretPath}/{appName}/{username}", mountPoint: MOUNT_POINT);
                var secret = (Dictionary<string, object>)kv2Secret.Result.Data.Data;
                foreach(var kv in secret)
                {
                    if(kv.Key == DATA_KEY)
                    {
                        encryptionKey = Convert.FromBase64String(kv.Value.ToString()!);
                    }
                }
                return encryptionKey;
            }
            catch (Exception ex)
            {
                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
                throw new Exception(ex.Message, ex);
            }
        }

        /// <summary>
        /// Updates a secret at the specified location: /secretpath/appName, using the patch update.
        /// The patch means updating only a part of the secret, the encryption key in this case, without having to manage all the metadata of the secret.
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="newEncryptionKey"></param>
        public async void UpdateEncryptionKey(string appName, string username, byte[] newEncryptionKey)
        {
            try
            {
                var newEncodedKey = Convert.ToBase64String(newEncryptionKey);
                var newSecret = new Dictionary<string, object>
                {
                    { DATA_KEY,  newEncodedKey }
                };
                await _vaultClient!.V1.Secrets.KeyValue.V2.WriteSecretAsync($"{_secretPath}/{appName}/{username}", newSecret, mountPoint: MOUNT_POINT);
            }
            catch (Exception ex)
            {
                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
                throw new Exception(ex.Message, ex);
            }
        }

        /// <summary>
        /// Deletes, permanently, the secret at the specified location and all it's versions.
        /// All version's history is removed.
        /// </summary>
        /// <param name="appName"></param>
        public async void DeleteEncryptionKey(string appName, string username)
        {
            try
            {
                await _vaultClient!.V1.Secrets.KeyValue.V2.DeleteMetadataAsync($"{_secretPath}/{appName}/{username}", MOUNT_POINT);
            }
            catch (Exception ex)
            {
                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
