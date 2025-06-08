using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pishrafte
{
    internal class Student : Person
    {
        public int StudentIDNumber;
        public Room Room;
        public Dormitory Dormitory;
        public Block Block;
        private List<Equipment> PersonalEquipments;

        public Student(string firstName, string lastName, int nationalIDNumber, int phoneNumber, string address, int age, int studentIDNumber)
                : base(firstName, lastName, nationalIDNumber, phoneNumber, address, age)
        {
            StudentIDNumber = studentIDNumber;
        }
















        public static Student CrateStudent(List<DormitoryManager> dormitoryManagers, List<Student> students, List<BlockManager> blockManagers)
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
        wrong7:
            int studentIDNumber;
            Console.Write("Enter Student id number: ");
            while (!int.TryParse(Console.ReadLine(), out studentIDNumber))
            {
                Console.Write("Invalid input. Please enter a valid Student id number: ");
            }
            if (Usermanager.StudentIDNumberExists(phonenumber, students))
            {
                Console.WriteLine("A user with this phonenumber already exists.");
                goto Wrong6;
            }

            return new Student(firstName, lastName, nationalId, phonenumber, address, age, studentIDNumber);
        }





        public static void SearchStudent(List<Student> students)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
    