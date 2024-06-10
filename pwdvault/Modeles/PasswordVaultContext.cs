/*
Netsho - Defines users and password data, implements the connection to database. 
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
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace pwdvault.Modeles
{
    /// <summary>
    /// Setting the Db Context of Entity Framework on AppPassword Model to create the corresponding table in the database.
    /// </summary>
    public class PasswordVaultContext : DbContext
    {
        public DbSet<AppPassword> Passwords { get; set; }
        public DbSet<User> Users { get; set; }


        // Delegate that writes database logs to the dbLog.txt in Local AppData folder
        private readonly Action<string> writeLogsToFile = (message) =>
        {
            string dbLogFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordVault");
            string dbLogFilePath = Path.Combine(dbLogFolderPath, "dbLog.txt");

            File.AppendAllText(dbLogFilePath, message + Environment.NewLine);
        };

        public PasswordVaultContext() : base()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        /// <summary>
        /// Configures the logging to dbLog.txt file, and configures the usage of the PostgreSQL connection string from app.config
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.EnableDetailedErrors(true)
                    .LogTo(writeLogsToFile, LogLevel.Warning)
                    .UseNpgsql(ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString);
            }
        }

        /// <summary>
        /// Creates the auto incremental primary key on the User Password Id.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppPassword>().HasKey(x => x.Id);
            modelBuilder.Entity<AppPassword>().Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }

    public class AppPassword
    {
        [Key]
        public int Id { get; set; }
        public string AppCategory { get; set; }
        public string AppName { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public string IconName { get; set; }
        public byte[] Bytes { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public AppPassword(string appCategory, string appName, string userName, byte[] password, string iconName, byte[] bytes)
        {
            AppCategory = appCategory;
            AppName = appName;
            UserName = userName;
            Password = password;
            IconName = iconName;
            Bytes = bytes;
        }
    }

    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public User(string username, byte[] passwordHash, byte[] passwordSalt)
        {
            Username = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
        }
    }
}
