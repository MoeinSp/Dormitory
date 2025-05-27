using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Pishrafte
{
    internal class User
    {
        public string Username;
        public string Password;
        public UserRole Role;
        public Person personinfo;

        public User(string username, string password, UserRole role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
        public User(string username, string password, UserRole role, Person person)
        {
            Username = username;
            Password = password;
            Role = role;
            personinfo = person;
        }
    }
}
