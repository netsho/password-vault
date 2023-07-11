using Microsoft.EntityFrameworkCore;
using pwdvault.Modeles;
using pwdvault.Services.Exceptions;
using Serilog;

namespace pwdvault.Services
{
    public class UserPasswordService
    {
        private readonly PasswordVaultContext dbContext;

        public UserPasswordService(PasswordVaultContext dbContext)
        {
            this.dbContext = dbContext;
            dbContext.SaveChangesFailed += SaveChangesOnFail;
        }

        /// <summary>
        /// Add an application's password in database.
        /// </summary>
        /// <param name="userPassword"></param>
        public void CreateUserPassword(UserPassword userPassword)
        {
            Log.Logger.Information("Adding a new password on database...");
            dbContext.Add(userPassword);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Deletes an application's password from database.
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="PasswordNotFoundException"></exception>
        public void DeleteUserPassword(int id)
        {
            Log.Logger.Information("Deleting a password from database...");
            // If UserPassword is null, throw the exception
            var UserPassword = dbContext.Passwords.Find(id) ?? throw new PasswordNotFoundException($"The password cannot be found !");
            dbContext.Remove(UserPassword);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Updates an application's password in database.
        /// </summary>
        /// <param name="userPasswordEdited"></param>
        public void UpdateUserPassword(UserPassword userPasswordEdited)
        {
            Log.Logger.Information("Updating a password on database...");
            dbContext.Update(userPasswordEdited);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Gets the application's password by it's name and user's name from database.
        /// Returns the user password if not null, else throw an exception.
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        /// <exception cref="PasswordNotFoundException"></exception>
        public UserPassword GetUserPassword(string appName, string username)
        {
            Log.Logger.Information($"Getting the {appName}'s password from database...");
            var UserPassword = dbContext.Passwords.FirstOrDefault(userPassword => userPassword.AppName == appName && userPassword.UserName == username);
            return UserPassword ?? throw new PasswordNotFoundException($"The password for {appName} cannot be found !");
        }

        /// <summary>
        /// Gets all the passwords of the connected user from database.
        /// </summary>
        /// <returns></returns>
        public List<UserPassword> GetAllUserPassword()
        {
            Log.Logger.Information("Retrieving all passwords from database...");
            return dbContext.Passwords.ToList();
        }

        public void SaveChangesOnFail(object? sender, SaveChangesFailedEventArgs e)
        {
            throw new Exception($"Saving failed due to :\n {e.Exception}.");
        }
    }
}
