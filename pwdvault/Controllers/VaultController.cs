using VaultSharp;
using VaultSharp.V1.AuthMethods;
using VaultSharp.V1.AuthMethods.AppRole;

namespace pwdvault.Controllers
{
    public sealed class VaultService
    {
        private readonly IVaultClient? _vaultClient;
        /// <summary>
        /// Lock object that will be used to synchronize threads during first access to the Singleton.
        /// </summary>
        private static readonly object _lock = new();
        private static VaultService? _instance;

        private VaultService(string roleID, string secretID, string vaultServerUri)
        {
            IAuthMethodInfo authMethodInfo = new AppRoleAuthMethodInfo(roleID, secretID);
            var vaultClientSettings = new VaultClientSettings(vaultServerUri, authMethodInfo);

            _vaultClient = new VaultClient(vaultClientSettings);
            _vaultClient.V1.Auth.PerformImmediateLogin();
        }

        /// <summary>
        /// Singleton implementation to have only one connection to Vault server.
        /// This pattern implementation is safe in multithread environment with a lazy initialization for the singleton objet and a double check lock.
        /// The first condition is needed to prevent threads stumbling over the lock once the instance is ready.
        /// The "lock" will be granted to only one thread, thus creating the VaultService instance while the others would be waiting for the lock to be released.
        /// Once released, the thread that might have been waiting for the lock may get it this time. But since the VaultService is already initialized, the thread won't create a new VaultService. 
        /// </summary>
        /// <param name="roleID"></param>
        /// <param name="secretID"></param>
        /// <param name="vaultServerUri"></param>
        /// <returns></returns>
        public static VaultService GetInstance(string roleID, string secretID, string vaultServerUri)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new VaultService(roleID, secretID, vaultServerUri);
                }
            }
            return _instance;
        }

        public void StoreEncryptionKey(byte[] encryptionKey)
        {

        }

        public void RetrieveEncryptionKey()
        {

        }

    }
}
