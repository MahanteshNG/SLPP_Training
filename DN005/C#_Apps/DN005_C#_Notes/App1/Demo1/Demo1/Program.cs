/* Namespaces */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program  //Executable class
    {
        //Executable Method Main()
        static void Main(string[] args)
        {
            //Console Class
            //ReadLine(): Input Method [Data is always read in string format]
            //WriteLine() or Write(): Output Method
            Console.WriteLine("Enter Trainee Name:");
            string traineeName = Console.ReadLine();
            Console.WriteLine("Enter Date of Joining (dd/MM/yyyy):");
            //Convert String Input to DateTime
            DateTime dateOfJoining = DateTime.ParseExact(
                Console.ReadLine(), "dd/MM/yyyy",null);
            /* Check if Id is 4 digits long; otherwise inform user to reenter Id again */
            bool checkIdLength = false;
            int traineeId = 0;
            do
            {
                Console.WriteLine("Enter Trainee Id:");
                traineeId = int.Parse(Console.ReadLine());
                if(traineeId.ToString().Length==4)
                {
                    checkIdLength = true;
                    break;
                }
                else
                {
                    checkIdLength = false;
                    Console.WriteLine("Invalid Id..Enter 4 digits number only");
                }
            }
            while (checkIdLength == false);

            
            Console.WriteLine("Enter Marks:");
            double marks = double.Parse(Console.ReadLine());            

            Console.WriteLine("\nTrainee Name: " + traineeName);
            Console.WriteLine("Trainee Id: " + traineeId);
            Console.WriteLine("Joining Date: " + dateOfJoining.
                ToString("dd-MMMMM-yyyy"));
            Console.WriteLine("Marks: " + marks.ToString("0.00"));
            if (marks < 70)
            {
                Console.WriteLine("Trainee needs to give reattempt");
            }
            else
            {
                Console.WriteLine("Successfully completed exam");
            }
        }
    }
}
