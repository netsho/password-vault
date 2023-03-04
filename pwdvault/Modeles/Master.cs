using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwdvault.Modeles
{
    internal class Master
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set;}
        public byte[] PasswordSalt { get; set;}
    }
}
