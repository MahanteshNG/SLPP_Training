using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfCollectionObjectsEx2
{
    public class EmployeeDL
    {
        //auto implemented properties
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentName { get; set; }
        //default constructor
        public EmployeeDL()
        {

        }
        //Parameterized Constructor
        public EmployeeDL(int employeeId, string employeeName, string departmentName)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            DepartmentName = departmentName;
        }
        //override ToString() for output format
        public override string ToString()
        {
            return string.Format("{0,-20}{1,-20}{2}",
                this.EmployeeId, this.EmployeeName, this.DepartmentName);
        }
    }
}
