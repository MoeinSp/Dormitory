using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pishrafte
{
    internal class Usermanager
    {
        private List<User> users = new List<User>();
        private List<User> ADMIN = new List<User>
        {
            new User("ADMIN11","ADMIN11"),
            new User("ADMIN22","ADMIN22")
        };

        public void Adduser(User user)
        {
            users.Add(user);
        }
        public bool isUserExists(User user)
        {
            foreach (var item in users)
            {
                if (item.Username == user.Username && item.Password == user.Password)
                    return true;
            }
           return false;
        }
        public bool isADMIN(User user)
        {
            foreach (var item in ADMIN)
            {
                if (item.Username == user.Username && item.Password == user.Password)
                    return true;
            }
            return false;
        }
    }
}