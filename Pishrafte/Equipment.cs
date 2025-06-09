using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pishrafte
{
    internal class Equipment
    {
        public string Equimentname;
        public string Partnumber;
        public string AssetNumber;
        public string status;
        public Room Room;
        public Student Owner;


        public static void SohwEquipments(List<Equipment> equipments)
        {
            Console.WriteLine("Equipments List :");
            if (equipments.Count == 0)
            {
                Console.WriteLine("None");
                return;
            }
            int count = 1;
            foreach (Equipment equip in equipments)
            {

                Console.WriteLine(count+". "+equip.Equimentname);
            }
        }
    }
}