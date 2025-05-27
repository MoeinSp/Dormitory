using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Pishrafte
{
    internal class Usermanager
    {
        public static User CurrentUser;
        public static bool IsLoggedIn => CurrentUser != null;
        public static void Logout()
        {
            CurrentUser = null;
        }

        public static bool IsInRole(UserRole role)
        {
            return CurrentUser != null && CurrentUser.Role == role;
        }
        private List<User> students = new List<User>();
        private List<User> Blockmanagers = new List<User>();
        private List<User> Dormitorymanagers = new List<User>();
        private List<User> ADMIN = new List<User>
        {
            new User("ADMIN11","ADMIN11",Program.UserRole.Admin),
            new User("ADMIN22","ADMIN22",Program.UserRole.Admin)
        };

        public void Addstudent(User student)
        {
            students.Add(student);
        }
        public void AddBlockmanager(User Blockmanager)
        {
            Blockmanagers.Add(Blockmanager);
        }
        public void AddDormitorymanager(User Dormitorymanager)
        {
            Dormitorymanagers.Add(Dormitorymanager);
        }
        public bool NationalIdExists(int NationalId)
        { 
        }
        public bool StudentIDNumberExists(int StudentIDNumber)
        { }
        public bool PhonenumberExists(int Phonenumber)
        { }
        public String isUserExists(User user)
        {
            foreach (var item in students)
            {
                if (item.Username == user.Username && item.Password == user.Password)
                    return "student";
            }
            foreach (var item in Blockmanagers)
            {
                if (item.Username == user.Username && item.Password == user.Password)
                    return "Blockmanager";
            }
            foreach (var item in Dormitorymanagers)
            {
                if (item.Username == user.Username && item.Password == user.Password)
                    return "Dormitorymanager";
            }
            foreach (var item in ADMIN)
            {
                if (item.Username == user.Username && item.Password == user.Password)
                    return "Admin";
            }
            return "false";
        }
    }
}