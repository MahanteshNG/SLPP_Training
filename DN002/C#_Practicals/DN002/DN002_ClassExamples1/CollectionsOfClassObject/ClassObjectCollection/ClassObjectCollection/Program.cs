using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 3 Tire Arctitecture:
 * Presenation Layer (PL) where users interact to provide input and receive output
 * Data Layer (DL) where data is stored
 * Business Logic Layer (BL) which performs operations like data output logic operation
 * */

/* Write a program to create a List of Employees and do the following:
 * Display All Employees
 * Display All Employees belonging to searched department
 * Display All Employees who belong to the searched department and working in searched Technology
 * Display an Employee by Id search*/
namespace ClassObjectCollection
{
    //UI (User Interface) class or PL (Presentation Layer) Class
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring a generic List to contain a list of Employees
            List<EmployeeDL> li = new List<EmployeeDL>();
            EmployeeDL dl = new EmployeeDL();
            string loopInput = string.Empty;
            do
            {
                Console.WriteLine("Enter Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Department: ");
                string department = Console.ReadLine();
                Console.WriteLine("Enter Technology: ");
                string technology = Console.ReadLine();
                //Pass the input to the EmployeeDL Constructor
                dl = new EmployeeDL(id, name, department, technology);

                //Add the dl object to the List Collection
                li.Add(dl);
                Console.WriteLine("Enter Yes to continue...Any other key to stop:");
                loopInput = Console.ReadLine();
                Console.WriteLine();
            }
            while (loopInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine("\nDisplay All Employees.....");
            EmployeeBL.DisplayAllEmployees(li);

            //Console.WriteLine("\nDisplay All Employees working in Searched Department...");
            //Console.WriteLine("Enter Department Name to search: ");
            //string searchDept = Console.ReadLine();
            //EmployeeBL.DisplayEmployeesByDepartment(li, searchDept);

            //Console.WriteLine("\nDisplay All Employees working in Searched Department and Searched Technology...");
            //Console.WriteLine("Enter Department Name to search: ");
            //string searchDept = Console.ReadLine();
            //Console.WriteLine("Enter Technology to Search: ");
            //string searchTech = Console.ReadLine();
            //EmployeeBL.DisplayEmployeesByDeptAndTech(li, searchDept, searchTech);

            Console.WriteLine("\nDisplay An Employee By Searched Id...");
            Console.WriteLine("Enter Id to search: ");
            int searchId = int.Parse(Console.ReadLine());
            EmployeeBL.DisplayEmployeeById(li, searchId);
        }
    }
}
