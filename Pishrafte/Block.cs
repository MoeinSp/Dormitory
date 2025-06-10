using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pishrafte
{
    internal class Block
    {
        public string Name;
        public string Address;
        public int NumberofFloors;
        public BlockManager BlockManager;
        public List<Room> Rooms = new List<Room>();
        public Dormitory Dormitory;
        public int capacity => 6 * Rooms.Count - Capacityy(Rooms);




        public Block(string name, string address, int numberofFloors,List<Room> rooms, BlockManager blockManager)
        {
            Name = name;
            Address = address;
            NumberofFloors = numberofFloors;
            Rooms = rooms;
            BlockManager = blockManager;
        }


        public int Capacityy(List<Room> Rooms)
        {
            int count = 0;
            foreach (Room room in Rooms) {
                count += room.capacity;
            }
            return count;
        }







        public static Room ShowBlockRooms(List<Room> roomList)
        {
            Console.WriteLine("Room List :");
            if (roomList.Count == 0)
            {
                Console.WriteLine("Empty");
                return null;
            }
            int count = 1;
            foreach (Room room in roomList)
            {
                Console.WriteLine(count + ". Room Id: " + room.RoomID);
                count++;
            }
            int input;
            do
            {
                Console.WriteLine("From the list of available Room, please enter the number of your choice:");

            }
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > roomList.Count);
            if (roomList[input - 1].capacity == 0)
            {
                Console.WriteLine("FULL");
                return null;
            }
            return roomList[input - 1];
        }








        public static (Block, BlockManager,Student) CrateBlock(List<DormitoryManager> dormitoryManagers, List<Student> students, List<BlockManager> blockManagers)
            {
            Console.WriteLine("=== Block Registration ===");

            Console.Write("Enter Block Name: ");
            string Name = Console.ReadLine();

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            int NumberofFloors;
            Console.Write("Enter Number of Floors: ");
            while (!int.TryParse(Console.ReadLine(), out NumberofFloors))
            {
                Console.Write("Invalid input. Please enter a valid Number of Floors ");
            }
            int NumberRoom;
            Console.Write("Enter Room Number: ");
            while (!int.TryParse(Console.ReadLine(), out NumberRoom))
            {
                Console.Write("Invalid input. Please enter a valid Room Number ");
            }
            List<Room> roomList = new List<Room>();
            for (int i = 0; i < NumberRoom; i++)
            {
                Console.WriteLine(i+1+". Room");
                int RoomId;
                Console.Write("Enter RoomId: ");
                while (!int.TryParse(Console.ReadLine(), out RoomId))
                {
                    Console.Write("Invalid input. Please enter a valid Room ID ");
                }
                int NumberofFloorss;
                Console.Write("Enter Number of Floors: ");
                while (!int.TryParse(Console.ReadLine(), out NumberofFloorss))
                {
                    Console.Write("Invalid input. Please enter a valid Number of Floors ");
                }
                Room room = new Room(RoomId,NumberofFloorss);
                roomList.Add(room);
            }
            BlockManager manager;
            Student student1;
            if (BlockManager.countWithoutBlock(blockManagers) > 0)
            {
                manager = BlockManager.SelectBlockManagerN(blockManagers);
                student1=null;
                
            }
            else if(students.Count>0)
            {
                Student student = Student.SelectStudentFromAll(students);
                manager = new BlockManager(student.FirstName, student.LastName,student.NationalIDNumber,student.PhoneNumber,student.Address,student.Age,student.StudentIDNumber);
                student1 = student;
            }
            else
            {
                var touple = BlockManager.CrateBlockManager(dormitoryManagers, students, blockManagers);
                manager = touple.Item2;
                student1 = touple.Item1;
            }
            return (new Block(Name, address, NumberofFloors, roomList, manager), manager, student1);


        }











        public static Block SelectBlock(List<Block> blocks)
        {
            for (int i = 1; i <= blocks.Count; i++)
            {
                Console.WriteLine(i + ". Block Name: " + blocks[i - 1].Name );
            }
            int input;

            do
            {
                Console.WriteLine("From the list of available block, please enter the number of your choice:");

            }
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > blocks.Count);

            return blocks[input - 1];
        }




        public static void ShowlistBlock(List<Block> blocks)
        {
            for (int i = 1; i <= blocks.Count; i++)
            {
                Console.WriteLine(i + ". Block Name: " + blocks[i - 1].Name + " " + ", Address: " + blocks[i - 1].Address);
            }
            int input;
            do
            {
                Console.WriteLine("Please enter 1 to continue:");
            } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);



        }



    }

}
