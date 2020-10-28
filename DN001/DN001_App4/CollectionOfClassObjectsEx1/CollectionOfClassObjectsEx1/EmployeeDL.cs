using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfClassObjectsEx1
{
    //Model Class or Storage Class
    public class EmployeeDL
    {
        //Auto Implemented Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string JobRole { get; set; }
        //default constructor
        public EmployeeDL()
        {

        }
        //parameterized constructor
        public EmployeeDL(int id, string name, string department, string jobRole)
        {
            Id = id;
            Name = name;
            Department = department;
            JobRole = jobRole;
        }
        //output format
        public override string ToString()
        {
            return string.Format("{0,-20}{1,-20}{2,-20}{3}",
                this.Id, this.Name, this.Department, this.JobRole);
        }

    }
}
