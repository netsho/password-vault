using Microsoft.EntityFrameworkCore;
using pwdvault.Modeles;
using Serilog;

namespace pwdvault.Services
{
    public class UserManager
    {
        private readonly PasswordVaultContext dbContext;

        public UserManager(PasswordVaultContext dbContext)
        {
            this.dbContext = dbContext;
            dbContext.SaveChangesFailed += SaveChangesOnFail;
        }

        /// <summary>
        /// Adds the user in database.
        /// </summary>
        /// <param name="user"></param>
        public void CreateUser(User user)
        {
            Log.Logger.Information("Creating a new user in database...");
            dbContext.Add(user);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Gets the user from database.
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            Log.Logger.Information("Retrieving users from database...");
            return dbContext.Users.ToList();
        }

        public void SaveChangesOnFail(object? sender, SaveChangesFailedEventArgs e)
        {
            throw new Exception($"Saving failed due to :\n {e.Exception}.");
        }
    }
}
