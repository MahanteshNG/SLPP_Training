using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee tr = new Trainee();
            Console.WriteLine("Enter Trainee Id: ");
            int traineeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Trainee Name:");
            string traineeName = Console.ReadLine();
            Console.WriteLine("Enter Date of Joining(in yyyy/MM/dd format):");
            DateTime dateOfJoining = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd", null);
            Console.WriteLine("Enter Number of Subjects:");
            int subjectCount = int.Parse(Console.ReadLine());
            string[] subjects = new string[subjectCount];
            Console.WriteLine("Enter Subject Names:");
            for(int i=0;i<subjectCount;i++)
            {
                subjects[i] = Console.ReadLine();
            }
            //Pass the data under constructor of Trainee class
            tr = new Trainee(traineeId, traineeName, dateOfJoining);
            Console.WriteLine("\n");
            //Extract Data From class members using Properties
            Console.WriteLine("Trainee Id: " + tr.TraineeId + "\nTrainee Name: " +
                tr.TraineeName + "\nDate of Joining: " + tr.DateOfJoining.ToString("dd-MM-yyyy"));
            tr.SubjectInfo(subjectCount);
            tr.SubjectInfo(subjects);

        }
    }
}
