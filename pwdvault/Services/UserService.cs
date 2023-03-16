using Microsoft.EntityFrameworkCore;
using pwdvault.Modeles;

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

        public void CreateUserAccount(User masterAccount)
        {
            dbContext.Add(masterAccount);
            dbContext.SaveChanges();
        }

        public List<User> GetUserAccounts()
        {
            return dbContext.Accounts.ToList();
        }

        public void SaveChangesOnFail(object? sender, SaveChangesFailedEventArgs e)
        {
            throw new Exception($"Saving failed due to :\n {e.Exception}.");
        }
    }
}
