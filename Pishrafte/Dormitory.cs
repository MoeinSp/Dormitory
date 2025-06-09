using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pishrafte
{
    internal class Dormitory
    {
        public string Name;
        public string Address;
        public int MaximumCapacity;
        public DormitoryManager DormitoryManager;
        private List<Block> BLOCK=new List<Block>();
        public Dormitory(string name, string address, int maximumcapacity, DormitoryManager dormitorymanager)
        {
            Name = name;
            Address = address;
            MaximumCapacity = maximumcapacity;
            DormitoryManager = dormitorymanager;
        }
        public Dormitory(string name, string address, int maximumcapacity)
        {
            Name = name;
            Address = address;
            MaximumCapacity = maximumcapacity;
        }

        public static void ShowBlock(Dormitory dormitory)
        {
            Console.WriteLine("Block List :");
            if (dormitory.BLOCK.Count == 0)
            {
                Console.WriteLine("Empty");
                return;
            }
            int count = 1;
            foreach (Block block in dormitory.BLOCK)
            {
                Console.WriteLine(count + ". Block Name: " + block.Name + " " + ", Address: " + block.Address);
                count++;
            }
        }

        public static Block ShowDormitoryBlocks(Dormitory dormitory)
        {
            Console.WriteLine("Block List :");
            if (dormitory.BLOCK.Count == 0)
            {
                Console.WriteLine("Empty");
                return null;
            }
            int count = 1;
            foreach (Block block in dormitory.BLOCK)
            {
                Console.WriteLine(count + ". Block Name: " + block.Name + " " + ", Address: " + block.Address);
                count++;
            }
            int input;
            do
            {
                Console.WriteLine("From the list of available Block, please enter the number of your choice:");

            }
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > dormitory.BLOCK.Count);
            return dormitory.BLOCK[input-1];
        }








        public static void Showdata(Dormitory dormitory)
        {
            Console.WriteLine("Dormitory Name: " + dormitory.Name);
            Console.WriteLine("Address: " + dormitory.Address);
            Console.WriteLine("Maximum Capacity: " + dormitory.MaximumCapacity);
            Console.WriteLine("Dormitory Manager Name: " + (dormitory.DormitoryManager == null ? "None" : (dormitory.DormitoryManager.FirstName + " " + dormitory.DormitoryManager.LastName)));
            Console.WriteLine("Address: " + dormitory.Address);
            ShowBlock(dormitory);
        }









        public static int IndexdDormitoryManager(List<Dormitory> dormitories, DormitoryManager dormitoryManager)
        {
            for (int i = 0; i < dormitories.Count; i++)
            {
                if (dormitories[i].DormitoryManager.NationalIDNumber == dormitoryManager.NationalIDNumber)
                    return i;
            }
            return -1;
        }










        public static Dormitory ChangeDormitory(Dormitory dormitory)
        {
            Console.Clear();
            Console.WriteLine("Choose which section you want to change :");
            Console.WriteLine("1. dormitory name");
            Console.WriteLine("2. dormitory address");
            Console.WriteLine("3. dormitory maximum capacity");
            Console.WriteLine("0. back");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    return dormitory;
                    break;
                case 1:
                    Console.WriteLine("Enter new name");
                    string name = Console.ReadLine();
                    dormitory.Name = name;
                    Console.WriteLine("Operation completed successfully. Press 1 to continue:");
                    int input;
                    do
                    {
                    } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                    ChangeDormitory(dormitory);
                    break;
                case 2:
                    Console.WriteLine("Enter new address");
                    string address = Console.ReadLine();
                    dormitory.Address = address;
                    Console.WriteLine("Operation completed successfully. Press 1 to continue:");
                    do
                    {
                    } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                    ChangeDormitory(dormitory);
                        break;
                case 3:
                    Console.WriteLine("Enter new maxiumcapacity");
                    int max;
                    while (!int.TryParse(Console.ReadLine(), out max))
                    {
                        Console.Write("Invalid input. Please enter a valid maxiumcapacity: ");
                    }
                    dormitory.MaximumCapacity = max;
                    Console.WriteLine("Operation completed successfully. Press 1 to continue:");
                    do
                    {
                    } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                    ChangeDormitory(dormitory);
                    break;
                default:
                    string invalid;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid option.");
                        Console.WriteLine("Enter [0] to return");
                        invalid = Console.ReadLine();
                    } while (invalid != "0");
                    ChangeDormitory(dormitory);
                    break;
            }
            return dormitory;
            
        }













        public static Dormitory ShowListDormitory(List<Dormitory> dormitories)
        {
            for (int i = 1; i <= dormitories.Count; i++)
            {
                Console.WriteLine(i + ". Dormitory Name: " + dormitories[i - 1].Name + " " + ", MaximumCapacity: " + dormitories[i - 1].MaximumCapacity);
            }
            int input;

            do
            {
                Console.WriteLine("From the list of available dormitory, please enter the number of your choice:");

            }
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > dormitories.Count);

            return dormitories[input - 1];
        }




        public static int SelectDormitoryAllFromList(List<Dormitory> dormitories)
        {
            for (int i = 1; i <= dormitories.Count; i++)
            {
                Console.WriteLine(i + ". Dormitory Name: " + dormitories[i - 1].Name + " " + ", MaximumCapacity: " + dormitories[i - 1].MaximumCapacity);
            }
            int input;

            do
            {
                Console.WriteLine("From the list of available dormitory, please enter the number of your choice:");

            }
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > dormitories.Count);

            return input;
        }






















        public int AssignDormitoryToManager(List<DormitoryManager> dormitoryManagers)
        {
            for (int i = 0; i < dormitoryManagers.Count; i++)
            {
                if (DormitoryManager.NationalIDNumber == dormitoryManagers[i].NationalIDNumber)
                {
                    return i;
                }
            }
            return 0;
        }
        public static (Dormitory, DormitoryManager) CrateDormitory(List<DormitoryManager> dormitoryManagers, List<Student> students, List<BlockManager> blockManagers)
        {
            Console.WriteLine("=== Dormitory Registration ===");

            Console.Write("Enter Dormitory Name: ");
            string Name = Console.ReadLine();

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            int Capacity;
            Console.Write("Enter Maximum Capacity: ");
            while (!int.TryParse(Console.ReadLine(), out Capacity))
            {
                Console.Write("Invalid input. Please enter a valid Maximum Capacity ");
            }
            DormitoryManager manager;
            if (DormitoryManager.countWithoutDormitory(dormitoryManagers) > 0)
            {
                manager = DormitoryManager.SelectDormitoryManagerN(dormitoryManagers);
                return (new Dormitory(Name, address, Capacity, manager), null);
            }
            else
            {
                manager = DormitoryManager.CrateDormitoryManager(dormitoryManagers, students, blockManagers);
            }
            return (new Dormitory(Name, address, Capacity, manager), manager);
        }
    }
}