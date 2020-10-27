using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Class_Collection
{
    public interface IOperation
    {
        List<EmployeeDL> DisplayAllrecords(List<EmployeeDL> employeeList);
        EmployeeDL DisplayEmployeeById(List<EmployeeDL> employeeList, int searchId);
        List<EmployeeDL> DisplayEmployeeByDepartment(List<EmployeeDL> employeeList, string searchDepartment);
    }
}
