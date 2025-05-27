using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pishrafte
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        public int NationalIDNumber;
        public int PhoneNumber;
        public string Address;
        public int Age;
        public Person(string firstName, string lastName, int nationalIDNumber, int phoneNumber, string address, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            NationalIDNumber = nationalIDNumber;
            PhoneNumber = phoneNumber;
            Address = address;
            Age = age;
        }
    }
}
