using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Create a List of Class Objects of Employees and then do the following:
 * (i) Display all Employees
 * (ii) Display Searched Employees by Department
 * (iii) Display Searched Employee by Employee Id and department
 * */
//The architectural pattern consisting of Data Logic (DL Layer),
//Business Logic (Business Layer) and Presenatation Logic (PL Layer)
//is called 3-tire Architecture
namespace ListOfCollectionObjectsEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a List of Class Objects
            List<EmployeeDL> li = new List<EmployeeDL>();
            EmployeeDL dl = new EmployeeDL();
            string loopInput = string.Empty;
            do
            {
                Console.WriteLine("Enter Employee Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Department: ");
                string department = Console.ReadLine();
                //Pass these input data to parameterized constructor of Employee
                dl = new EmployeeDL(id, name, department);
                //Add the class object to the list to create list of class objects
                li.Add(dl);
                Console.WriteLine("Enter yes to continue..Any other key to stop: ");
                loopInput = Console.ReadLine();
            }
            while (loopInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine("\nDiplay All Employees:");
            List<EmployeeDL> storageList1 = EmployeeBL.DisplayAllEmployees(li);
            Console.WriteLine("\n{0,-20}{1,-20}{2}", "Employee Id", "Employee Name", "Department");
            foreach (var employee in storageList1)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("\nDisplay Employees By Searched Department: ");
            Console.WriteLine("Enter Department Name to Search: ");
            string searchDept = Console.ReadLine();
            List<EmployeeDL> storageList2 = EmployeeBL.DisplayEmployeesByDepartment(li, searchDept);
            if (storageList2.Count > 0) //ie searchDept matches with Employee Records
            {
                Console.WriteLine("\n{0,-20}{1,-20}{2}", "Employee Id", "Employee Name", "Department");
                foreach (var employee in storageList2)
                {
                    Console.WriteLine(employee);
                }
            }
            else
            {
                Console.WriteLine("No Employee Information found");
            }

            Console.WriteLine("\nDisplay Employee By Searched Id and Deparment Name: ");
            Console.WriteLine("Enter Id to Search: ");
            int searchId = int.Parse(Console.ReadLine());
            EmployeeDL dl1 = EmployeeBL.DisplayEmployeeById(li, searchId);
            if (dl1 != null) //ie searched Id and Department record found in Collection
            {
                Console.WriteLine("\n{0,-20}{1,-20}{2}", "Employee Id", "Employee Name", "Department");
                Console.WriteLine(dl1);
            }
            else
            {
                Console.WriteLine("No Employee Information found");
            }
        }
    }
}
