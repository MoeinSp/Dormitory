using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pishrafte
{
    internal class Room
    {
        public int RoomID;
        public int NumberofFloors;
        private int MaximumCapacity = 6;
        public List<Equipment> Equipments;
        public List<Student> Students;
        public Block Boluk;
      ///یادت باشه شرط ظرفیت رو بزاری توی متد اد
    }
}
