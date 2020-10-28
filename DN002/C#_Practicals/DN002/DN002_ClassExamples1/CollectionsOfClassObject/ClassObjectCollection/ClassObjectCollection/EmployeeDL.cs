using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectCollection
{
    //Model class or Data Layer (DL) class
    //This class is used to store records
   public class EmployeeDL
    {
        //Auto-Implememted Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Technology { get; set; }
        //default constructor
        public EmployeeDL()
        {

        }
        //Parameterized Constructor
        public EmployeeDL(int id, string name, string department, string technology)
        {
            Id = id;
            Name = name;
            Department = department;
            Technology = technology;
        }
        public override string ToString()
        {
            return string.Format("{0,-20}{1,-20}{2,-20}{3}",
                this.Id, this.Name, this.Department, this.Technology);
        }
    }
}
