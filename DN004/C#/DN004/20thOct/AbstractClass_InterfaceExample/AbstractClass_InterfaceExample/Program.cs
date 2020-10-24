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
            Console.WriteLine("Enter Coach Id: ");
            int coachId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Coach Name: ");
            string coachName = Console.ReadLine();
            Console.WriteLine("Enter Trainee Id: ");
            int traineeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Batch Code: ");
            string batchCode = Console.ReadLine();

            tr = new Trainee(coachId, coachName, traineeId, batchCode);

            Console.WriteLine("\nTrainee Id: " + tr.TraineeId);
            Console.WriteLine("Batch Code: " + tr.BatchCode + "\nCoach Id: " + tr.CoachId +
                "\nCoach Name: " + tr.CoachName);
            tr.TraineeAttendance();
            tr.BusinessUnitRule();
            tr.AcademyRule();

        }
    }
}
