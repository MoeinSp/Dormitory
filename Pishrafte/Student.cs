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
    }
}