using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Class_Collection
{
    //Model class or Data layer Class
    public class EmployeeDL
    {
        //class members
        private int _employeeId;
        private string _employeeName;
        private string _department;
        //properties
        public int EmployeeId { get => _employeeId; set => _employeeId = value; }
        public string EmployeeName { get => _employeeName; set => _employeeName = value; }
        public string Department { get => _department; set => _department = value; }
        //Default Constructor
        public EmployeeDL()
        {

        }
        //Parameterized Constructor
        public EmployeeDL(int employeeId, string employeeName, string department)
        {
            _employeeId = employeeId;
            _employeeName = employeeName;
            _department = department;
        }
    }
}
