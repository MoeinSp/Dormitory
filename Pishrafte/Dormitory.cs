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
        public Dormitory CrateDormitory(List<DormitoryManager> listD)
        {
            Console.WriteLine("=== Dormitory Registration ===");

            Console.Write("Enter Dormitory Name: ");
            string Name = Console.ReadLine();

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            int Capacity;
            while (!int.TryParse(Console.ReadLine(), out Capacity))
            {
                Console.Write("Invalid input. Please enter a valid Maximum Capacity ");
            }
            if (listD.Count > 0)
            {
                DormitoryManager manager = DormitoryManager.SelectDormitoryManager(listD);
            }
            else
            {
                DormitoryManager manager = DormitoryManager.CrateDormitoryManager(listD);
            }
            return new Dormitory(Name, Address, MaximumCapacity, manager);
        }
    }
}