using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfClassObjectsEx1
{
    //Business Logic Layer(BL) Class or Operational Class
    //Write Methods for Data Ouput
    public class EmployeeBL
    {
        //Display all employees present under the list
        public static void DisplayAllEmployees(List<EmployeeDL> list)
        {           
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3}", "Employee Id",
                "Employee Name", "Department", "Job Role");
            foreach(var employee in list)
            {
                Console.WriteLine(employee);
            }
        }

        //Search all employees belonging to a particular department
        public static void SearchEmployeeByDepartment(List<EmployeeDL> list,string searchDept)
        {
            var searchEmployees = list.Where(x => x.Department.Equals(searchDept,
                  StringComparison.InvariantCultureIgnoreCase)).ToList();

            if(searchEmployees.Count>0) //ie Employee Department matches with seached department
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3}", "Employee Id",
                "Employee Name", "Department", "Job Role");
                foreach (var employee in searchEmployees)
                {
                    Console.WriteLine(employee);
                }
            }
            else
            {
                Console.WriteLine("Searched Deparment Info not present");
            }
        }

        //Search all employees by department name and job role
        public static void SearchEmployeeByRoleAndDept(List<EmployeeDL> list,
            string searchDept,string searchJobRole)
        {
            var searchEmployees = list.Where(x => x.Department.Equals(searchDept,
                  StringComparison.InvariantCultureIgnoreCase) &&
                  x.JobRole.Equals(searchJobRole,StringComparison.InvariantCultureIgnoreCase)).ToList();

            if (searchEmployees.Count > 0) //ie Employee Department matches with seached department
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3}", "Employee Id",
                "Employee Name", "Department", "Job Role");
                foreach (var employee in searchEmployees)
                {
                    Console.WriteLine(employee);
                }
            }
            else
            {
                Console.WriteLine("Searched Deparment Info or Job Role not present");
            }           
            
        }

        //Search an employee by Employee Id
        public static void DisplayEmployeeById(List<EmployeeDL> list,int searchId)
        {
            //If you want to extract only a single record from a collection using LINQ
            //use the FirstOrDefault() method
            var searchEmployee = list.Where(x => x.Id == searchId).FirstOrDefault();
            if(searchEmployee!=null) //ie searchId matches with Employee Id
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3}", "Employee Id",
               "Employee Name", "Department", "Job Role");                
               Console.WriteLine(searchEmployee);                
            }
            else
            {
                Console.WriteLine("Searched Employee Id not found");
            }
        }
    }
}
