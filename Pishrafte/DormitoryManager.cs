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
        public static DormitoryManager SelectDormitoryManager(List<DormitoryManager> dormitoryManagers)
        {
            for (int i = 1; i <= dormitoryManagers.Count;i++)
            {
                Console.WriteLine(i + ". Name: " + dormitoryManagers[i-1].FirstName + " "+ dormitoryManagers[i-1].LastName + ", NationalIDNumber: " + dormitoryManagers[i - 1].NationalIDNumber);
            }
            int input;

            do
            {
                Console.Write("Please enter a number between " + 1 + " and " + dormitoryManagers.Count + ":" );
            }
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > dormitoryManagers.Count);

            return dormitoryManagers[input-1];
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
