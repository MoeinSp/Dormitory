using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pishrafte
{
    internal class User
    {
        public string Username;
        public string Password;
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
