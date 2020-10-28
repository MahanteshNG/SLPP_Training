using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 3 Tire Architecture where there are 3 layers:
 * PL to give user the platform to enter data and view result
 * Data Layer or DL to Store Data
 * BL or Business Layer to perform operatoions on Data */

/* Write a program to create a List of Employees and do the following operation:
 * (i) Display all employees present under the list
 * (ii) Search all employees belonging to a particular department
 * (iii) Search all employees by department name and job role
 * (iv) Search an employee by Employee Id */
namespace CollectionOfClassObjectsEx1
{
    //UI class or Presentation Layer (PL) Class
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a List with Employees
            List<EmployeeDL> li = new List<EmployeeDL>();
            EmployeeDL dl = new EmployeeDL();
            string loopInput = string.Empty;
            do
            {
                Console.WriteLine("Enter Employee Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Employee Department: ");
                string department = Console.ReadLine();
                Console.WriteLine("Enter Employee Job Role: ");
                string jobRole = Console.ReadLine();
                //Pass the data to constructor of EmployeeDL
                dl = new EmployeeDL(id, name, department, jobRole);
                //Add the dl object to the list to create a list of Employee DL
                li.Add(dl);
                Console.WriteLine("Enter Yes to continue..Any other key to stop:");
                loopInput = Console.ReadLine();
                Console.WriteLine();
            }
            while (loopInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine("\nDisplay All Employees....");
            EmployeeBL.DisplayAllEmployees(li);

            //Console.WriteLine("\nDisplay Employees by Searched Department......");
            //Console.WriteLine("Enter Department Name to search: ");
            //string searchDept = Console.ReadLine();
            //EmployeeBL.SearchEmployeeByDepartment(li, searchDept);

            //Console.WriteLine("\nDisplay Employees by Searched Department and Job Role......");
            //Console.WriteLine("Enter Department Name to search: ");
            //string searchDept = Console.ReadLine();
            //Console.WriteLine("Enter Job Role to search: ");
            //string searchJobRole = Console.ReadLine();
            //EmployeeBL.SearchEmployeeByRoleAndDept(li, searchDept, searchJobRole);

            Console.WriteLine("\nDisplay Employees by Searched Employee Id......");
            Console.WriteLine("Enter Id to search: ");
            int searchId = int.Parse(Console.ReadLine());
            EmployeeBL.DisplayEmployeeById(li, searchId);
        }
    }
}
