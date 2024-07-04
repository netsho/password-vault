/*
Netsho - Implements CRUD methods for managing users in the database. 
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
using Microsoft.EntityFrameworkCore;
using pwdvault.Models;
using pwdvault.Services.Exceptions;

namespace pwdvault.Controllers
{
    public class UserController
    {
        private readonly PasswordVaultContext _dbContext;

        public UserController(PasswordVaultContext dbContext)
        {
            this._dbContext = dbContext;
            dbContext.SaveChangesFailed += SaveChangesOnFail;
        }

        /// <summary>
        /// Adds the user in database.
        /// </summary>
        /// <param name="user"></param>
        public void CreateUser(User user)
        {
            if (!UserExists(user.Username))
            {
                _dbContext.Add(user);
                _dbContext.SaveChanges();
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
            return GetAllUsers().Exists(user => user.Username.ToLower().Equals(username.ToLower()));
        }

        /// <summary>
        /// Gets the user from database by username.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        /// <exception cref="UserException"></exception>
        public User GetUserByUsername(string username)
        {
            var user = GetAllUsers().Find(user => user.Username.ToLower().Equals(username.ToLower()));
            if (user is not null)
            {
                return _dbContext.Users.Find(user.Id)!;
            }
            throw new UserException($"No account is found with the username \"{username}\". Please ensure the username is correct or sign up for a new account.");
        }

        /// <summary>
        /// Gets the users from database.
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }

        public void SaveChangesOnFail(object? sender, SaveChangesFailedEventArgs e)
        {
            throw new InvalidOperationException($"Saving failed due to :\n {e.Exception}.");
        }
    }
}
