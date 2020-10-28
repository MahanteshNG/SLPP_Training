using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Class_Collection
{
    //Presentation Layer Class
    class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeDL> employeeList = new List<EmployeeDL>();
            string loopInput = string.Empty;
            do
            {
                Console.WriteLine("Enter Employee Id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Department the Employee is working:");
                string department = Console.ReadLine();
                //Pass the input under class construtor
                EmployeeDL employee = new EmployeeDL(id, name, department);
                //each time loop runs add employee object under collection
                employeeList.Add(employee);
                Console.WriteLine("Press Yes to continue..Any other key to terminate");
                loopInput = Console.ReadLine();
            }
            while (loopInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));

            string loopOutput = string.Empty;
            Operation operation = new Operation();
            Console.WriteLine("\n*****************************************");
            do
            {
                Console.WriteLine("Menu:\n1. Display All Employees\n2. Display Employee By Id" +
                    "\n3. Display All Employees working in searched Department");
                int menu = int.Parse(Console.ReadLine());
                switch(menu)
                {
                    case 1:
                        List<EmployeeDL> outputAllEmployees = operation.DisplayAllrecords(employeeList);
                        Console.WriteLine("{0,-20}{1,-20}{2}", "Employee Id", "Employee Name", "Department");
                        foreach(var data in outputAllEmployees)
                        {
                            Console.WriteLine("{0,-20}{1,-20}{2}", data.EmployeeId, data.EmployeeName,
                                data.Department);
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Enter Id to search:");
                        int searchId = int.Parse(Console.ReadLine());
                        EmployeeDL getEmployeeById = operation.
                            DisplayEmployeeById(employeeList, searchId);
                        if(getEmployeeById!=null) //ie employee record is found
                        {
                            Console.WriteLine("Employee Id: {0}\nEmployee Name: {1}\n" +
                                "Employee Department: {2}", getEmployeeById.EmployeeId,
                                getEmployeeById.EmployeeName, getEmployeeById.Department);
                        }
                        else
                        {
                            Console.WriteLine("Searched Employee Id not exist");
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Enter Department to search: ");
                        string searchDepartment = Console.ReadLine();
                        List<EmployeeDL> outputEmployeesByDepartment =
                            operation.DisplayEmployeeByDepartment(employeeList, searchDepartment);
                        Console.WriteLine("{0,-20}{1,-20}{2}", "Employee Id", "Employee Name", "Department");
                        foreach (var data in outputEmployeesByDepartment)
                        {
                            Console.WriteLine("{0,-20}{1,-20}{2}", data.EmployeeId, data.EmployeeName,
                                data.Department);
                        }
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Invalid Menu Entry");
                        break;
                }

                Console.WriteLine("Press Yes to continue...Any other key to terminate");
                loopOutput = Console.ReadLine();
            }
            while (loopOutput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
