using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace
using System.Globalization;
namespace DateTimeClassEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Current Date and Time
           DateTime curDate = DateTime.Now;
            /*Console.WriteLine("Current Date and Time: " + curDate);
           Console.WriteLine("\nDisplay Current Date in dd.MM.yyyy format: " +
               curDate.ToString("dd.MM.yyyy"));*/
            TraineeDl dl = new TraineeDl();
            Console.WriteLine("Enter Trainee Id:");
            int traineeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Trainee Name: ");
            string traineeName = Console.ReadLine();
            DateTime dob;
            bool checkDob = false;
            do
            {
                try
                {
                    Console.WriteLine("Enter Dob (in dd/MM/yyyy format): ");
                    dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",
                       CultureInfo.InvariantCulture);
                    //Timespan Class -> It calculates the interval between 2 date values (in number of days)
                    TimeSpan ts = curDate.Subtract(dob);

                    if (dob != null && (int)ts.TotalDays != 0 && dob.CompareTo(curDate) < 0
                      && (int)(ts.TotalDays / 365) >= 18) //ie date format of entry is correct
                    {
                        checkDob = true;
                        //CompareTo is used to compare between 2 values
                        //Result: >0 if first value>second value
                        //<0 if first value<second value; 0 if first value=second value

                        dl = new TraineeDl(traineeId, traineeName, dob);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Date of Birth");
                    }
                        
                    
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    checkDob = false;
                }
            }
            while (checkDob == false);
            Console.WriteLine("\nTrainee Output: ");
            Console.WriteLine(dl);
            

        }
    }
}
