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
        public int tabaghe;
        private int zarfiat = 6;
        public List<Equipment> Equipments;
        public List<Daneshju> Daneshjus;
        public Boluk Boluk;
      ///یادت باشه شرط ظرفیت رو بزاری توی متد اد
    }
}
