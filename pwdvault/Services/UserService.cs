using Microsoft.EntityFrameworkCore;
using pwdvault.Modeles;
using Serilog;

namespace pwdvault.Services
{
    public class UserService
    {
        private readonly PasswordVaultContext dbContext;

        public UserService(PasswordVaultContext dbContext)
        {
            this.dbContext = dbContext;
            dbContext.SaveChangesFailed += SaveChangesOnFail;
        }

        /// <summary>
        /// Adds the user's account in database.
        /// </summary>
        /// <param name="masterAccount"></param>
        public void CreateUserAccount(User masterAccount)
        {
            Log.Logger.Information("Creating user password on database...");
            dbContext.Add(masterAccount);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Gets the user's account from database.
        /// </summary>
        /// <returns></returns>
        public List<User> GetUserAccounts()
        {
            Log.Logger.Information("Retrieving user password from database...");
            return dbContext.Accounts.ToList();
        }

        public void SaveChangesOnFail(object? sender, SaveChangesFailedEventArgs e)
        {
            throw new Exception($"Saving failed due to :\n {e.Exception}.");
        }
    }
}
