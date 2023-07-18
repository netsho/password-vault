using Microsoft.EntityFrameworkCore;
using pwdvault.Modeles;
using pwdvault.Services.Exceptions;
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
            if(!UserExists(user.Username))
            {
                Log.Logger.Information("Creating a new user in database...");
                dbContext.Add(user);
                dbContext.SaveChanges();
            }
            else
            {
                throw new UserException("Username already in use. Please try logging in or use a different username.");
            }
        }

        /// <summary>
        /// Checks if the user already exists by username.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool UserExists(string username)
        {
            foreach(var user in GetUsers())
            {
                if(user.Username.ToLower().Equals(username.ToLower())) 
                {
                    return true;                
                }
            }
            return false;
        }

        /// <summary>
        /// Gets the user from database by username.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        /// <exception cref="UserException"></exception>
        public User GetUserByUsername(string username)
        {
            foreach (var user in GetUsers())
            {
                if (user.Username.ToLower().Equals(username.ToLower()))
                {
                    return dbContext.Users.Find(user.Id)!;
                }
            }
            throw new UserException("No account found with this username. Please ensure the username is correct or sign up for a new account.");
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
