using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee tr = new Trainee();

            Console.WriteLine("Enter Batch Id:");
            string batchId = Console.ReadLine();
            Console.WriteLine("Enter Trainee Id:");
            int traineeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Trainee Name:");
            string traineeName = Console.ReadLine();
            Console.WriteLine("Enter Monthly Salary: ");
            double salary = double.Parse(Console.ReadLine());

            tr = new Trainee(batchId, traineeId, traineeName);
            tr.BusinessUnitRule();
            tr.BatchInfo();
            tr.TraineeInfo();
            Console.WriteLine("Annual Salary: " + tr.TraineeAnnualSalary(salary));
        }
    }
}
