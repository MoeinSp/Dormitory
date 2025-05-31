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
        public bool NationalIdExists(int NationalId, List<Student> students,List<DormitoryManager> dormitoryManagers , List<BlockManager> blockManagers)
        {
            foreach(Student student in students)
                if(NationalId==student.NationalIDNumber) return true;
            foreach(BlockManager blockManager in blockManagers)
                if(NationalId == blockManager.NationalIDNumber) return true;
            foreach(DormitoryManager dormitoryManager in dormitoryManagers)
                if(NationalId == dormitoryManager.NationalIDNumber) return true;
            return false;
        }
        public bool StudentIDNumberExists(int StudentIDNumber, List<Student> students, List<BlockManager> blockManagers)
        {
            foreach (Student student in students)
                if (StudentIDNumber == student.NationalIDNumber) return true;
            foreach (BlockManager blockManager in blockManagers)
                if (StudentIDNumber == blockManager.NationalIDNumber) return true;
            return false;
        }
        
        public bool PhonenumberExists(int Phonenumber, List<Student> students, List<DormitoryManager> dormitoryManagers, List<BlockManager> blockManagers)
        {
            foreach (Student student in students)
                if (Phonenumber == student.NationalIDNumber) return true;
            foreach (BlockManager blockManager in blockManagers)
                if (Phonenumber == blockManager.NationalIDNumber) return true;
            foreach (DormitoryManager dormitoryManager in dormitoryManagers)
                if (Phonenumber == dormitoryManager.NationalIDNumber) return true;
            return false;
        }
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
                    return "Block Manager";
            }
            foreach (var item in Dormitorymanagers)
            {
                if (item.Username == user.Username && item.Password == user.Password)
                    return "Dormitory Manager";
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