using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pishrafte
{
    internal class DormitoryManager  : Person
    {
        public string Role;
        public Dormitory Dormitory;
        public DormitoryManager(string firstName, string lastName, int nationalIDNumber, int phoneNumber, string address, int age, string role)
            : base(firstName, lastName, nationalIDNumber, phoneNumber, address, age)
        {
            Role = role;
        }
    }
}
