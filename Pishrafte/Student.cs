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

        public Student(string firstName, string lastName, int nationalIDNumber, int phoneNumber, string address, int age, int studentIDNumber)
                : base(firstName, lastName, nationalIDNumber, phoneNumber, address, age)
        {
            StudentIDNumber = studentIDNumber;
        }
    }
}