using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfClassObjectsEx1
{
    //This is the operational class where we will write output logic
    public class EmployeeBL
    {
        public static void DisplayAllEmployees(List<EmployeeDL> li)
        {
            Console.WriteLine("\n{0,-20}{1,-20}{2}", "Employee Id", "Employee Name", "Department");
            foreach(var employee in li)
            {
                Console.WriteLine(employee);
            }
        }

        public static void DisplayEmployeesByDepartment
            (List<EmployeeDL> li,string searchDeptartment)
        {
            var find = li.Where(x => x.DepartmentName.
              Equals(searchDeptartment, StringComparison.InvariantCultureIgnoreCase)).ToList();

            if (find.Count>0) //ie searchDept matches with Employee Records
            { 
            Console.WriteLine("\n{0,-20}{1,-20}{2}", "Employee Id", "Employee Name", "Department");
                foreach (var employee in find)
                {
                    Console.WriteLine(employee);
                }               
            }
            else
            {
                Console.WriteLine("No Employee Information found");
            }
        }

        public static void DisplayEmployeeByIDAndDepartment
            (List<EmployeeDL> li,int searchId,string searchDeptartment)
        {
            //FirstOrDefault is to be used if LINQ search results in a single output
            var find = li.Where(x => x.EmployeeId == searchId && x.DepartmentName.
              Equals(searchDeptartment, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
            if(find!=null) //ie searched Id and Department record found in Collection
            {
                Console.WriteLine("\n{0,-20}{1,-20}{2}", "Employee Id", "Employee Name", "Department");
                Console.WriteLine(find);
            }
            else
            {
                Console.WriteLine("No Employee Information found");
            }
        }
    }
}
