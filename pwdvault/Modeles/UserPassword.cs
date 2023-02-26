using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwdvault.Modeles
{
    internal class UserPassword
    {
        private int cId;
        private string cAppCategory;
        private string cAppName;
        private string cUsername;
        private string cPassword;

        public int Id { get; set; }
        public string AppCategory { get; set; }
        public string AppName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
