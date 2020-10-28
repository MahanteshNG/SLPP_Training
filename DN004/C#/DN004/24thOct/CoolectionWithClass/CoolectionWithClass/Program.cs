using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Create a list of class objects; pass data to class and display data from the list */
namespace CoolectionWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a List with class as datatype
            List<Employee> EmployeeList = new List<Employee>();
            Employee employee = new Employee();
            string loopInput = string.Empty;
            do
            {
                Console.WriteLine("Enter Employee Informations:");
                Console.WriteLine("Enter Employee Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Date of Joining(in dd/MM/yyyy format):");
                DateTime doj = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",
                    CultureInfo.InvariantCulture);
                Console.WriteLine("Enter Department:");
                string department = Console.ReadLine();
                employee = new Employee(id, name, doj,department);
                //To create List of class objects; add the class object to the list
                EmployeeList.Add(employee);
                Console.WriteLine("Enter yes to continue..any other key to terminate:");
                loopInput = Console.ReadLine();
                Console.WriteLine();
            }
            while (loopInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine("\n{0,-20}{1,-20}{2,-20}{3}", "Employee Id", "Employee Name", 
                "Joining Date","Department");
            Utility.DisplayAllEmployees(EmployeeList);

            Console.WriteLine("Enter Department Name to search: ");
            string searchDept = Console.ReadLine();
            Console.WriteLine("\n{0,-20}{1,-20}{2,-20}{3}", "Employee Id", "Employee Name",
                "Joining Date", "Department");
            Utility.DisplayEmployeesByDepartment(EmployeeList, searchDept);

            Console.WriteLine("\nEnter Employee Id to search:");
            int searchId = int.Parse(Console.ReadLine());
            Console.WriteLine("\n{0,-20}{1,-20}{2,-20}{3}", "Employee Id", "Employee Name",
                "Joining Date", "Department");
            Utility.DisplayEmployeeById(EmployeeList, searchId);
        }
    }
}
