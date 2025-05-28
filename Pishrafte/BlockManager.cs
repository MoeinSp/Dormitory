using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pishrafte
{
    internal class BlockManager:Student
    {
        public string Role;
        public Block Block;
        public BlockManager(string firstName, string lastName, int nationalIDNumber, int phoneNumber, string address, int age, int studentIDNumber,string role) 
            : base(firstName, lastName, nationalIDNumber, phoneNumber, address, age,studentIDNumber)
        { 
            Role = role;
        }
    }
}
