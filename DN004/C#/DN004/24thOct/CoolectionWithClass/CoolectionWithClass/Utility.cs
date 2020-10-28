using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolectionWithClass
{
    //This is the operational class where you write code logic for output
    public class Utility
    {
        public static void DisplayAllEmployees(List<Employee> list)
        {
            foreach(var data in list)
            {
                Console.WriteLine(data);
               
            }
        }

        //Display all employees belonging to searched department
        public static void DisplayEmployeesByDepartment
            (List<Employee> list,string searchDepartment)
        {
            var employeeInfo = list.Where(x => x.Department == searchDepartment).ToList();
            /* var employeeInfo=from x in list where x.Department==searceDepartment select x).ToList();*/
            if (employeeInfo.Count > 0) //ie searchDepartment is found under list
            {
                foreach (var data in employeeInfo)
                {
                    Console.WriteLine(data);
                }
            }
            else
            {
                Console.WriteLine("Search Department does not exist");
            }
        }

        //Search an Employee via Employee Id
        public static void DisplayEmployeeById(List<Employee> list,int searchId)
        {
            //FirstorDefault is taken if linq query or lamda expression filters
            //out a single record from the collection
            var employeeInfo = list.Where(x => x.EmployeeId == searchId).FirstOrDefault();
            if(employeeInfo!=null) //ie employee Id is found
            {
                Console.WriteLine(employeeInfo);
            }
            else
            {
                Console.WriteLine("Search Employee does not exist");
            }
        }
    }
}
