using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_Arrays
{
    class Program  //Executable Class
    {
        static void Main(string[] args) //Executable Method
        {
            Demo demo = new Demo();
            Console.WriteLine("Enter Company Name:");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter Comany HO Location:");
            string companyHO = Console.ReadLine();
            demo.CompanyName(companyName);
            Console.WriteLine("India Head Office: " + demo.CompanyHO(companyHO));
            Console.WriteLine("Enter the number of departments whose revenue you want to calcuate:");
            int departmentNumbers = int.Parse(Console.ReadLine());
            double[] Revenue = new double[departmentNumbers];
            Console.WriteLine("Enter Revenue for each department:");
            for(int i=0;i<Revenue.Length;i++)
            {
                Revenue[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Total Revenue Generated: " +
                Demo.TotalRevenue(Revenue, departmentNumbers));
            
            Console.WriteLine("\nEnter Employee Id:");
            Demo.EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            Demo.EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter monthly salary:");
            Demo.MonthlySalary = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEmployee Details:");
            Demo.EmployeeDisplay();
            Console.WriteLine("Employee Yearly CTC: " + Demo.AnnualSalary());        

        }
    }
}
