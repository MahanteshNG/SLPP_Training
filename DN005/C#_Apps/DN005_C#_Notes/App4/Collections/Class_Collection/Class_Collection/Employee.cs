using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Collection
{
    public class Employee
    {
        //Auto Implemented Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public Employee()
        {

        }

        public Employee(int id, string name, DateTime dateOfJoining)
        {
            Id = id;
            Name = name;
            DateOfJoining = dateOfJoining;
        }

        public override string ToString()
        {
            return string.Format("{0,-20}{1,-20}{2}",
                this.Id, this.Name, this.DateOfJoining.ToString("dd.MM.yyyy"));
        }
    }
}
