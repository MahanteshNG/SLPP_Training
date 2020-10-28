using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectCollection
{
    //This class is called Business Logic (BL) class under where we can write
    //logic or methods for data operations like output operations
    public class EmployeeBL
    {
        //Display All Employees
        public static void DisplayAllEmployees(List<EmployeeDL> list)
        {
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3}",
                "Employee Id", "Employee Name", "Department", "Technology");
            foreach(var employee in list)
            {
                Console.WriteLine(employee);
            }
        }

        //Display All Employees belonging to searched department
        public static void DisplayEmployeesByDepartment(List<EmployeeDL> list,string searchDept)
        {
            var searchEmployee = list.Where(x => x.Department.Equals(searchDept,
                  StringComparison.InvariantCultureIgnoreCase)).ToList();
            if(searchEmployee.Count>0) //ie employee department info matches with searched dept
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3}",
                "Employee Id", "Employee Name", "Department", "Technology");
                foreach (var employee in searchEmployee)
                {
                    Console.WriteLine(employee);
                }
            }
            else
            {
                Console.WriteLine("Searched Department does not exist in Collection");
            }
        }

        //Display All Employees who belong to the searched department and working in searched Technology
        public static void DisplayEmployeesByDeptAndTech(List<EmployeeDL> list,
            string searchDept,string searchTech)
        {
            var searchEmployee = list.Where(x => x.Department.Equals(searchDept,
                 StringComparison.InvariantCultureIgnoreCase) && 
                 x.Technology.Equals(searchTech,StringComparison.InvariantCultureIgnoreCase))
                 .ToList();
            if (searchEmployee.Count > 0) //ie employee department info matches with searched dept
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3}",
                "Employee Id", "Employee Name", "Department", "Technology");
                foreach (var employee in searchEmployee)
                {
                    Console.WriteLine(employee);
                }
            }
            else
            {
                Console.WriteLine("Searched Department or Technology does not exist in Collection");
            }
        }

        //Display an Employee by Id search
        public static void DisplayEmployeeById(List<EmployeeDL> list,int searchId)
        {
            //FirstOrDefault() have to be included if LINQ extracts a single record from collection
            var searchEmployee = list.Where(x => x.Id == searchId).FirstOrDefault();
            if(searchEmployee!=null) //ie Employee Id and search id matches
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3}",
               "Employee Id", "Employee Name", "Department", "Technology");
                Console.WriteLine(searchEmployee);
            }
            else
            {
                Console.WriteLine("Searched Employee Id not present in collection");
            }
        }
    }
}
