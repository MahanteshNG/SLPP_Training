using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolectionWithClass
{
    //model class or storage class
    public class Employee
    {
        //auto implemented property
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Department { get; set; }
        //default or parameterless constructor
        public Employee()
        {

        }

        public Employee(int employeeId, string employeeName, DateTime dateOfJoining, string department)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            DateOfJoining = dateOfJoining;
            Department = department;
        }

        //parameterized Constructor

        public override string ToString()
        {
            return string.Format("{0,-20}{1,-20}{2,-20}{3}",
                this.EmployeeId, this.EmployeeName, this.DateOfJoining.ToString("dd.MM.yyyy"),
                this.Department);
        }
    }
}
