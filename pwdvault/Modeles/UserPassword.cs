using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace pwdvault.Modeles
{
    public class UserPassword
    {
        [Key]
        public int Id { get; set; }
        public string AppCategory { get; set; }
        public string AppName { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public string IconName { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public UserPassword(string appCategory, byte[] password)
        {
            AppCategory = appCategory;
            Password = password;
        }
        public UserPassword(string appCategory, string appName, string userName, byte[] password, string iconName)
        {
            AppCategory = appCategory;
            AppName = appName;
            UserName = userName;
            Password = password;
            IconName = iconName;
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

    /// <summary>
    /// Setting the Db Context of Entity Framework on UserPassword Model, to create the corresponding table in the database.
    /// </summary>
    public class PasswordVaultContext : DbContext
    {
        public DbSet<UserPassword> Passwords { get; set; }
        public DbSet<User> Accounts { get; set; }


        // Delegate that writes database logs to the dbLog.txt in Local AppData folder
        Action<string> writeLogsToFile = (message) =>
        {
            string dbLogFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordVault");
            string dbLogFilePath = Path.Combine(dbLogFolderPath, "dbLog.txt");

            File.AppendAllText(dbLogFilePath, message + Environment.NewLine);
        };

        public PasswordVaultContext() : base() { }

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
