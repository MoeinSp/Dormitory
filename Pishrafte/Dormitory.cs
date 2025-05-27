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
    }
}
