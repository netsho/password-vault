using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwdvault.Modeles
{
    internal class Master
    {
        private int cId;
        private string cUsername;
        private byte[] cPasswordHash;
        private byte[] cPasswordSalt;

        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set;}
        public byte[] PasswordSalt { get; set;}
    }
}
