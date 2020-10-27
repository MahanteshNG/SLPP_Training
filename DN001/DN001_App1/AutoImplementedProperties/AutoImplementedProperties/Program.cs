using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoImplementedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Check if Trainee Id is valid [A valid Id will contain first 3 letters in capital 
             * and next will 4 numbers from 0 to 9]. If valid continue your input; otherwise
             * give a message "Invalid Input..Try Again" */
            Trainee tr = new Trainee();
            string id = string.Empty;
            bool idCheck = false;
            string pattern = @"^[A-Z]{3}[0-9]{4}$";
            do
            {
                Console.WriteLine("Enter Trainee Id: ");
                id = Console.ReadLine();
                idCheck = Regex.IsMatch(id, pattern);
                if (idCheck == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Id Entered...Try Again");
                }
            }
            while (idCheck == false);

            Console.WriteLine("Enter Trainee Name:");
            string name = Console.ReadLine();

            //pass data to constructor
            tr = new Trainee(id, name);

            //Console.WriteLine("Trainee Name: " + tr.TraineeName + "\nTrainee Id: " + tr.TraineeId);
            Console.WriteLine(tr);
        }
    }
}
