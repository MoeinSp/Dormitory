using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pishrafte
{ 
    internal class BlockManager : Student
    {
        public string Role;
        public Block Block;
        public BlockManager(string firstName, string lastName, int nationalIDNumber, int phoneNumber, string address, int age, int studentIDNumber)
            : base(firstName, lastName, nationalIDNumber, phoneNumber, address, age, studentIDNumber)
        {
        }



        public static BlockManager SelectBlockManagerN(List<BlockManager> blockmanagers)
        {
            if (blockmanagers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            int count = 1;
            for (int i = 0; i < blockmanagers.Count; i++)
            {
                if (blockmanagers[i].Block == null)
                {
                    Console.WriteLine(count + ". Name: " + blockmanagers[i].FirstName + " " + blockmanagers[i].LastName + ", NationalIDNumber: " + blockmanagers[i].NationalIDNumber);
                    count++;
                }
            }
            int input;

            do
            {
                Console.WriteLine("From the list of available block managers, please enter the number of your choice:");

            }
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > blockmanagers.Count);

            return blockmanagers[input - 1];
        }




        public static int countWithoutBlock(List<BlockManager> blockmanagers)
        {
            int count = 0;
            for (int i = 0; i < blockmanagers.Count; i++)
            {
                if (blockmanagers[i].Dormitory == null)
                {
                    count++;
                }
            }
            return count;
        }



        public static (Student,BlockManager) CrateBlockManager(List<DormitoryManager> dormitoryManagers, List<Student> students, List<BlockManager> blockManagers)
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
            Student managerr = new Student(firstName, lastName, nationalId, phonenumber, address, age, studentIDNumber);
            BlockManager manager = new BlockManager(firstName, lastName, nationalId, phonenumber, address, age, studentIDNumber);
            return (managerr,manager);
        }





    }
}
