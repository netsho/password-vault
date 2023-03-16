using Microsoft.EntityFrameworkCore;
using pwdvault.Modeles;
using pwdvault.Services.Exceptions;

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

        public void CreateUserPassword(UserPassword userPassword)
        {
            dbContext.Add(userPassword);
            dbContext.SaveChanges();
        }

        public void DeleteUserPassword(int id)
        {
            var UserPassword = dbContext.Passwords.Find(id);

            if (UserPassword == null)
            {
                throw new PasswordNotFoundException($"The password cannot be found !");
            }

            dbContext.Remove(UserPassword);
            dbContext.SaveChanges();
        }

        public void UpdateUserPassword(UserPassword userPasswordEdited)
        {
            dbContext.Update(userPasswordEdited);
            dbContext.SaveChanges();
        }

        public UserPassword GetUserPassword(string appName, string username)
        {
            var UserPassword = dbContext.Passwords.FirstOrDefault(userPassword => userPassword.AppName == appName && userPassword.UserName == username);

            if (UserPassword == null)
            {
                throw new PasswordNotFoundException($"The password cannot be found !");
            }
            return UserPassword;
        }

        public List<UserPassword> GetAllUserPassword()
        {
            return dbContext.Passwords.ToList();
        }

        public void SaveChangesOnFail(object? sender, SaveChangesFailedEventArgs e)
        {
            throw new Exception($"Saving failed due to :\n {e.Exception}.");
        }
    }
}
