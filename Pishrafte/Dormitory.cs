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
        private List<Block> BLOCK;
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











        public static int IndexdDormitoryManager(List<Dormitory> dormitories, DormitoryManager dormitoryManager)
        {
            for(int i = 0;i<dormitories.Count;i++)
            {
                if (dormitories[i].DormitoryManager.NationalIDNumber == dormitoryManager.NationalIDNumber) 
                    return i;
            }
            return -1;
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
        public static (Dormitory,DormitoryManager) CrateDormitory(List<DormitoryManager> dormitoryManagers, List<Student> students, List<BlockManager> blockManagers)
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
            if (DormitoryManager.countWithoutDormitory(dormitoryManagers)>0)
            {
                manager = DormitoryManager.SelectDormitoryManagerN(dormitoryManagers);
                return (new Dormitory(Name, address, Capacity, manager), null);
            }
            else
            {
                manager = DormitoryManager.CrateDormitoryManager(dormitoryManagers, students, blockManagers);
            }
            return (new Dormitory(Name, address, Capacity, manager),manager);
        }
    }
}