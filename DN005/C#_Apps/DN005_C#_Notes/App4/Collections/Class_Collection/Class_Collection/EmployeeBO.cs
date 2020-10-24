using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Collection
{
    public class EmployeeBO
    {
        public void DisplayAllEmployees(List<Employee> empList)
        {
            Console.WriteLine("{0,-20}{1,-20}{2}", "Employee Id","Employee Name", "Joining Date");
            foreach(Employee employee in empList)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
