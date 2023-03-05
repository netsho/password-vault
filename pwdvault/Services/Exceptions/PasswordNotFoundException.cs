using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwdvault.Services.Exceptions
{
    internal class PasswordNotFoundException : Exception
    {
        public PasswordNotFoundException() { }

        public PasswordNotFoundException(string message) : base(message) { }

        public PasswordNotFoundException(string message, Exception innerException) : base(message, innerException) { }


    }
}
