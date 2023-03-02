using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        public string Password { get; set; }
    }

    public class PasswordsDbContext : DbContext
    {
        public DbSet<UserPassword> Passwords { get; set;}
    }
}
