﻿using Microsoft.EntityFrameworkCore;
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
            Log.Logger.Information("Adding a new password on database...");
            _dbContext.Add(password);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Deletes an application's password from database.
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="PasswordNotFoundException"></exception>
        public void DeletePassword(int id)
        {
            Log.Logger.Information("Deleting a password from database...");
            // If AppPassword is null, throw the exception
            var password = _dbContext.Passwords.Find(id) ?? throw new PasswordNotFoundException($"The password cannot be found !");
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
        /// <exception cref="PasswordNotFoundException"></exception>
        public AppPassword GetPassword(string appName, string username)
        {
            Log.Logger.Information($"Getting the {appName}'s password from database...");
            var password = _dbContext.Passwords.FirstOrDefault(password => password.AppName == appName && password.UserName == username);
            return password ?? throw new PasswordNotFoundException($"The password for {appName} cannot be found !");
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