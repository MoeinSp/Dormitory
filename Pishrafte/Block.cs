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
        public int capacity => 6*Rooms.Count-Capacityy(Rooms);



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
                Console.WriteLine(count + ". Room Id: " + room.RoomID );
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
            return roomList[input- 1];
        }

    }










  
}
