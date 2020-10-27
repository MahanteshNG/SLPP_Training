using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingEx1
{
    //storage class
    public class EmployeeDL
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime DateOfJoining { get; set; }
        public double Salary { get; set; }
        public EmployeeDL()
        {

        }

        public EmployeeDL(int employeeId, string employeeName, DateTime dateOfJoining, double salary)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            DateOfJoining = dateOfJoining;
            Salary = salary;
        }

        public override string ToString()
        {
            return string.Format("{0,-20}{1,-20}{2,-20}{3}",
                this.EmployeeId, this.EmployeeName, this.DateOfJoining.ToString("dd.MM.yyyy"),
                this.Salary);
        }
    }
}
