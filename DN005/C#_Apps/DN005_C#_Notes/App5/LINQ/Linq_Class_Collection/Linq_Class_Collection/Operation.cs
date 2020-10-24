using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Class_Collection
{
    public class Operation : IOperation
    {
        public List<EmployeeDL> DisplayAllrecords(List<EmployeeDL> employeeList)
        {
            return employeeList;
        }

        public List<EmployeeDL> DisplayEmployeeByDepartment(List<EmployeeDL> employeeList, 
            string searchDepartment)
        {
           var searchRecords = employeeList.
           Where(x => x.Department.Equals(searchDepartment, StringComparison.InvariantCultureIgnoreCase)).ToList();
            return searchRecords;
        }

        public EmployeeDL DisplayEmployeeById(List<EmployeeDL> employeeList, int searchId)
        {
            EmployeeDL emp = employeeList.
                Where(x => x.EmployeeId == searchId).FirstOrDefault();
            return emp;
        }
    }
}
