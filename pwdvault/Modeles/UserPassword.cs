using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwdvault.Modeles
{
    public class UserPassword
    {
        public int Id { get; set; }
        public string AppCategory { get; set; }
        public string AppName { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public UserPassword(string appCategory, string appName, string userName, byte[] password)
        {
            AppCategory = appCategory;
            AppName = appName;
            UserName = userName;
            Password = password;
        }
    }

    /// <summary>
    /// Setting the Db Context of Entity Framework on UserPassword Model, to create the corresponding table in the database.
    /// </summary>
    public class PasswordVaultContext : DbContext
    {
        public DbSet<UserPassword> Passwords { get; set;}

        // Delegate that writes database logs to the dbLog.txt in Local AppData folder
        Action<string> writeLogsToFile = (message) =>
        {
            string dbLogFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordVault");
            string dbLogFilePath = Path.Combine(dbLogFolderPath, "dbLog.txt");

            File.AppendAllText(dbLogFilePath, message + Environment.NewLine);
        };

        public PasswordVaultContext() : base() {}

        /// <summary>
        /// Configuring the logging to dbLog.txt file, and configuring the usage the SQL Server connection string from app.config
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.EnableDetailedErrors(true)
                    .LogTo(writeLogsToFile, LogLevel.Warning)
                    .UseSqlServer(ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString);
            }
        }

        /// <summary>
        /// Create the auto incremental primary key on the User Password Id.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPassword>().HasKey(x => x.Id);
            modelBuilder.Entity<UserPassword>().Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
