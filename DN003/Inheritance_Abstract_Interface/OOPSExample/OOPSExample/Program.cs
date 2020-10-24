using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee tr = new Trainee();

            Console.WriteLine("Enter Trainee Id: ");
            int traineeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Trainee Name: ");
            string traineeName = Console.ReadLine();
            Console.WriteLine("Enter Coach Id: ");
            int coachId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Coach Name: ");
            string coachName = Console.ReadLine();
            Console.WriteLine("Enter Batch Code: ");
            string batchCode = Console.ReadLine();
            Console.WriteLine("Enter Coach Monthly Salary: ");
            double salary = double.Parse(Console.ReadLine());

            tr = new Trainee(traineeId, traineeName,coachId,coachName,batchCode);

            //Use Trainee class object to provide output
            Console.WriteLine("\nOutput......");
            tr.AcademyRule();
            tr.BusinessRule();
            Console.WriteLine(tr);
            tr.BatchInfo();
            Console.WriteLine("Annual Salary of Coach: " +
                tr.CoachSalary(salary));


        }
    }
}
