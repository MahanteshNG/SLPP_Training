using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee();
            
            bool checkId = false;
            do
            {
                try
                {
                    Console.WriteLine("Enter Trainee Id: ");
                    Emp.Id = int.Parse(Console.ReadLine());
                    if (Emp.Id.ToString().Length == 4)
                    {
                        checkId = true;
                        break;
                    }
                }
                catch(FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                    checkId = false;

                }
            }
            while (checkId == false);

            Console.WriteLine("Enter Employee Name: ");
            Emp.Name = Console.ReadLine();

            double salary = 0;
            string returnInfo = string.Empty;
            SalaryValidation Validation = new SalaryValidation();
            do
            {
                Console.WriteLine("Enter Salary: ");
                salary = double.Parse(Console.ReadLine());
                returnInfo = Validation.ValidateSalaryInput(salary);
                if(returnInfo==null)
                {
                    Emp.Salary = salary;
                    break;
                }
                else
                {
                    Console.WriteLine("Salary Invalid..Should be >=10000");
                    Console.WriteLine("Try Again");
                }
            }
            while(returnInfo!=null);

            Console.WriteLine("Name: " + Emp.Name + "\nId: " + Emp.Id + "\nSalary: " +
                Emp.Salary);
        }
    }
}
