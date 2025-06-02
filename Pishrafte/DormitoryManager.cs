using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Pishrafte
{
    internal class DormitoryManager  : Person
    {
        public string Role;
        public Dormitory Dormitory;
        public DormitoryManager(string firstName, string lastName, int nationalIDNumber, int phoneNumber, string address, int age, string role)
            : base(firstName, lastName, nationalIDNumber, phoneNumber, address, age)
        {
            Role = role;
        }







        public static DormitoryManager ShowDormitoryManager(List<DormitoryManager> dormitoryManagers)
        {
            for (int i = 1; i <= dormitoryManagers.Count;i++)
            {
                Console.WriteLine(i + ". Name: " + dormitoryManagers[i-1].FirstName + " "+ dormitoryManagers[i-1].LastName + ", NationalIDNumber: " + dormitoryManagers[i - 1].NationalIDNumber);
            }
            int input;

            do
            {
                Console.WriteLine("From the list of available dormitory managers, please enter the number of your choice:");

            }
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > dormitoryManagers.Count);

            return dormitoryManagers[input-1];
        }



        public static int SselectDormitoryManager(List<DormitoryManager> dormitoryManagers)
        {
            int count = 1;
            for (int i = 0; i < dormitoryManagers.Count; i++)
            {
                if (dormitoryManagers[i].Dormitory == null)
                {
                    Console.WriteLine(count + ". Name: " + dormitoryManagers[i].FirstName + " " + dormitoryManagers[i].LastName + ", NationalIDNumber: " + dormitoryManagers[i].NationalIDNumber);
                    count++;
                }
            }
            int input;

            do
            {
                Console.WriteLine("From the list of available dormitory managers, please enter the number of your choice:");

            }
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > dormitoryManagers.Count);

            return count - 1;
        }












        public static DormitoryManager SelectDormitoryManager(List<DormitoryManager> dormitoryManagers)
        {
            int count = 1;
            for (int i = 0; i < dormitoryManagers.Count; i++)
            {
                if (dormitoryManagers[i].Dormitory == null)
                {
                    Console.WriteLine(count + ". Name: " + dormitoryManagers[i].FirstName + " " + dormitoryManagers[i].LastName + ", NationalIDNumber: " + dormitoryManagers[i].NationalIDNumber);
                    count++;
                }
            }
            int input;

            do
            {
                Console.WriteLine("From the list of available dormitory managers, please enter the number of your choice:");

            }
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > dormitoryManagers.Count);

            return dormitoryManagers[input - 1];
        }

        public static int countWithoutDormitory(List<DormitoryManager> dormitoryManagers)
        {
            int count = 0;
            for (int i = 0; i < dormitoryManagers.Count; i++)
            {
                if (dormitoryManagers[i].Dormitory == null)
                {
                    count++;
                }
            }
            return count;
        }




        public static void Showdata(DormitoryManager dormitoryManager)
        {
            Console.WriteLine("First Name: " + dormitoryManager.FirstName);
            Console.WriteLine("Last Name: " + dormitoryManager.LastName);
            Console.WriteLine("National ID: " + dormitoryManager.NationalIDNumber);
            Console.WriteLine("Phone Number: " + dormitoryManager.PhoneNumber);
            Console.WriteLine("Address: " + dormitoryManager.Address);
            Console.WriteLine("Age: " + dormitoryManager.Age);
            Console.WriteLine("Role: " + dormitoryManager.Role);
            Console.WriteLine("Dormitory Name: " + (dormitoryManager.Dormitory != null ? dormitoryManager.Dormitory.Name : "None"));
        }






        public static DormitoryManager CrateDormitoryManager(List<DormitoryManager> dormitoryManagers,List<Student> students,List<BlockManager> blockManagers)
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
        Wrong5:
            Console.Write("Enter National ID Number: ");
            int nationalId;
            while (!int.TryParse(Console.ReadLine(), out nationalId))
            {
                Console.Write("Invalid input. Please enter a valid National ID Number: ");
            }

            if (Usermanager.NationalIdExists(nationalId, students, dormitoryManagers, blockManagers))
            {
                Console.WriteLine("A user with this National ID already exists.");
                goto Wrong5;
            }
        Wrong6:
            int phonenumber;
            Console.Write("Enter PhoneNumber: ");
            while (!int.TryParse(Console.ReadLine(), out phonenumber))
            {
                Console.Write("Invalid input. Please enter a valid PhoneNumber: ");
            }

            if (Usermanager.PhonenumberExists(phonenumber, students, dormitoryManagers, blockManagers))
            {
                Console.WriteLine("A user with this phonenumber already exists.");
                goto Wrong6;
            }

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            int age;
            Console.Write("Enter Age: ");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Invalid input. Please enter a valid Age: ");
            }

            Console.Write("Enter Role: ");
            string role = Console.ReadLine();

            return new DormitoryManager(firstName, lastName, nationalId, phonenumber, address, age, role);
        }
    }
}
