using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee tr = new Trainee();
            Console.WriteLine("Enter Coach Name: ");
            string coachName = Console.ReadLine();
            Console.WriteLine("Enter Coach Id: ");
            int coachId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Trainee Name: ");
            string traineeName = Console.ReadLine();
            Console.WriteLine("Enter Trainee Id: ");
            int traineeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Batch Code: ");
            string batchCode = Console.ReadLine();

            //Pass Data to trainee class
            tr = new Trainee(coachId, coachName, traineeId, traineeName, batchCode);

            Console.WriteLine("\nOutput Details of Trainee:");
            /*
            tr.DisplayCoach();
            tr.DisplayTrainee();
            */
            Console.WriteLine(tr);

        }
    }
}
