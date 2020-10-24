using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            string loopInput = string.Empty;
            do
            {
                Console.WriteLine("Enter Employee Id:");
                int empId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                string empName = Console.ReadLine();
                Console.WriteLine("Enter Joining Date(MM/dd/yyyy):");
                DateTime empDOJ = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);

                Employee emp = new Employee(empId, empName, empDOJ);
                employeeList.Add(emp);
                Console.WriteLine("Press yes to continue..Any other key to terminate:");
                loopInput = Console.ReadLine();
            }
            while (loopInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine("\n*********************************");
            EmployeeBO bo = new EmployeeBO();
            bo.DisplayAllEmployees(employeeList);
        }
    }
}
