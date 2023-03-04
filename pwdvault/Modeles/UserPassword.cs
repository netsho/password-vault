using Microsoft.EntityFrameworkCore;
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

    public class PasswordVaultContext : DbContext
    {
        public DbSet<UserPassword> Passwords { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.EnableDetailedErrors(true)
                    .UseSqlServer(ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString);
            }
        }
    }
}
