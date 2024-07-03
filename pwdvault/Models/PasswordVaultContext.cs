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

namespace pwdvault.Models
{
    /// <summary>
    /// Setting the Db Context of Entity Framework on AppPassword Model to create the corresponding table in the database.
    /// </summary>
    public class PasswordVaultContext : DbContext
    {
        public DbSet<AppPassword> Passwords { get; set; }
        public DbSet<User> Users { get; set; }


        // Delegate that writes database logs to the dbLog.txt in Local AppData folder
        private readonly Action<string> _writeLogsToFile = (message) =>
        {
            string dbLogFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordVault");
            string dbLogFilePath = Path.Combine(dbLogFolderPath, "dbLog.txt");

            File.AppendAllText(dbLogFilePath, message + Environment.NewLine);
        };

        public PasswordVaultContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        /// <summary>
        /// Configures the logging to dbLog.txt file, and configures the usage of the PostGreSQL connection string from app.config
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.EnableDetailedErrors()
                    .LogTo(_writeLogsToFile, LogLevel.Warning)
                    .UseNpgsql(ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString);
            }
        }

        /// <summary>
        /// Creates the auto incremental primary key on the User Password ID.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppPassword>().HasKey(x => x.Id);
            modelBuilder.Entity<AppPassword>().Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }

    public class AppPassword(string appCategory, string appName, string userName, byte[] password, string iconName, byte[] bytes)
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string AppCategory { get; set; } = appCategory;

        [MaxLength(50)]
        public string AppName { get; set; } = appName;

        [MaxLength(50)]
        public string UserName { get; set; } = userName;

        [MaxLength(50)]
        public byte[] Password { get; set; } = password;

        [MaxLength(100)]
        public string IconName { get; set; } = iconName;
        public byte[] Bytes { get; set; } = bytes;
        public DateTime CreationTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }

    public class User(string username, byte[] passwordHash, byte[] passwordSalt)
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Username { get; set; } = username;
        public byte[] PasswordHash { get; set; } = passwordHash;
        public byte[] PasswordSalt { get; set; } = passwordSalt;
    }
}
