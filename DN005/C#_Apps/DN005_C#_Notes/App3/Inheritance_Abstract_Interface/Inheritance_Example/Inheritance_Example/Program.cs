using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee tr = new Trainee();
            Console.WriteLine("Enter Coach Id:");
            int coachId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Coach Name:");
            string coachName = Console.ReadLine();
            Console.WriteLine("Enter Trainee Id:");
            int traineeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Trainee Name:");
            string traineeName = Console.ReadLine();
            Console.WriteLine("Enter Batch Code:");
            string batchCode = Console.ReadLine();
            tr = new Trainee(coachId, coachName, traineeId, traineeName, batchCode);

            Console.WriteLine("Enter number of Subjects for MileStone1 Stage1:");
            int subjectNumber = int.Parse(Console.ReadLine());
            float[] marks = new float[subjectNumber];
            Console.WriteLine("Enter Marks:");
            for(int i=0;i<subjectNumber;i++)
            {
                marks[i] = float.Parse(Console.ReadLine());
            }

            bool returnMarks = tr.TraineeResult(marks, subjectNumber);

            Console.WriteLine("\nDisplay Output:");
            tr.DisplayCoach();
            tr.JoiningRule();
            tr.AcademyRule();
            tr.DisplayTrainee();
            if(returnMarks)
            {
                Console.WriteLine("Trainee can give ICT for Stage1");
            }
            else
            {
                Console.WriteLine("Trainee can not give ICT for Stage1");
            }
        }
    }
}
