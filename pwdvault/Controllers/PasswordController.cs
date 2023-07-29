using Microsoft.EntityFrameworkCore;
using pwdvault.Modeles;
using pwdvault.Services.Exceptions;
using Serilog;

namespace pwdvault.Controllers
{
    public class PasswordController
    {
        private readonly PasswordVaultContext _dbContext;

        public PasswordController(PasswordVaultContext dbContext)
        {
            this._dbContext = dbContext;
            dbContext.SaveChangesFailed += SaveChangesOnFail;
        }

        /// <summary>
        /// Add an application's password in database.
        /// </summary>
        /// <param name="password"></param>
        public void CreatePassword(AppPassword password)
        {
            if(!PasswordExists(password.AppName, password.UserName))
            {
                Log.Logger.Information("Adding a new password on database...");
                _dbContext.Add(password);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new PasswordException("The password for this account already exists. Please choose a unique name or update the existing password.");
            }
        }

        /// <summary>
        /// Deletes an application's password from database.
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="PasswordException"></exception>
        public void DeletePassword(int id)
        {
            Log.Logger.Information("Deleting a password from database...");
            // If AppPassword is null, throw the exception
            var password = _dbContext.Passwords.Find(id) ?? throw new PasswordException("The password for this account was not found. Please check the account name and try again.");
            _dbContext.Remove(password);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Updates an application's password in database.
        /// </summary>
        /// <param name="passwordEdited"></param>
        public void UpdatePassword(AppPassword passwordEdited)
        {
            Log.Logger.Information("Updating a password on database...");
            _dbContext.Update(passwordEdited);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Gets the application's password by it's name and user's name from database.
        /// Returns the user password if not null, else throw an exception.
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        /// <exception cref="PasswordException"></exception>
        public AppPassword GetPassword(string appName, string username)
        {
            Log.Logger.Information($"Getting the {appName}'s password from database...");
            var password = _dbContext.Passwords.FirstOrDefault(password => password.AppName == appName && password.UserName == username);
            return password ?? throw new PasswordException($"The password for the {appName} was not found. Please check the account name and try again.");
        }

        /// <summary>
        /// Checks if the password already exists by application's name and username.
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool PasswordExists(string appName, string username)
        {
            foreach (var password in GetAllPasswords())
            {
                if (password.AppName.ToLower().Equals(appName.ToLower()) && password.UserName.ToLower().Equals(username.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Gets all the passwords of the connected user from database.
        /// </summary>
        /// <returns></returns>
        public List<AppPassword> GetAllPasswords()
        {
            Log.Logger.Information("Retrieving all passwords from database...");
            return _dbContext.Passwords.ToList();
        }

        public void SaveChangesOnFail(object? sender, SaveChangesFailedEventArgs e)
        {
            throw new Exception($"Saving failed due to :\n {e.Exception}.");
        }
    }
}
