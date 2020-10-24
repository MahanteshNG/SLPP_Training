using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace for Regular Expression Validation
using System.Text.RegularExpressions;

namespace AutoImplemetedProperties_Example1
{
    /* Valid EmployeeId. A valid employee id is one whre the first 3 digits is capital letter
     * followed by 4 numbers between 0 to 9. Example: KAU1001 is valid; 1001KAU or kau1001 or
     * kau1 is invalid. Inform user to re-enter id again if Invalid and give a message "Invalid
     * Id...Enter Again" */
     //Pattern Matching: Class-> Regex  and Method-> IsMatch(input,pattern)
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            string id = string.Empty;
            bool checkId = false;
            do
            {
                Console.WriteLine("Enter Employee Id: ");
                id = Console.ReadLine();
                string pattern = @"^[A-Z]{3}[0-9]{4}$";
                checkId = Regex.IsMatch(id, pattern);
                if(checkId==true)
                {
                    emp.EmployeeId = id;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Id...Enter Id again");
                }
            }
            while (checkId == false);

            Console.WriteLine("Enter Employee Name: ");
            emp.EmployeeName = Console.ReadLine();

            Console.WriteLine("\n\nId: " + emp.EmployeeId + "\nEmployee Name: " + emp.EmployeeName);

            Trainee tr = new Trainee();
            Console.WriteLine("\n\nEnter trainee Id: ");
            tr.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Trainee Name: ");

            tr.Name = Console.ReadLine();
            double marks = 0;
            try
            {
                Console.WriteLine("Enter Marks: ");
                marks = double.Parse(Console.ReadLine());                
                tr.Marks = marks;
            }
            catch(Exception ex)
            {
                //The Message property of Exception class will display exception message
                Console.WriteLine(ex.Message);
            }
            if (tr.Marks > 0)
            {
                Console.WriteLine("\n\nTrainee Name: " + tr.Name + "\nId: " +
                    tr.Id + "\nMarks: " + tr.Marks);
            }
            else
            {
                Console.WriteLine("Data Invalid");
            }

        }
    }
}
