using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/* While entering check if the Trainee Id validates the below rule:
 * A valid trainee id should start with 3 capital letters followed by 4 numbers[anything between
 * 0-9]. If trainee id is valid pass the data to Trainee model class; otherwise inform the
 * user "Wrong Trainee Id..Try Again" and allow user to re-enter data */

namespace InheritanceEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee tr = new Trainee();
            string id = string.Empty;
            string traineeName = string.Empty;
            bool checkId = false;
            do
            {
                try
                {
                    Console.WriteLine("Enter trainee id: ");
                    id = Console.ReadLine();
                    string pattern = @"^[A-Z]{3}[0-9]{4}$";
                    checkId = Regex.IsMatch(id, pattern);
                    if(checkId==true)
                    {                        
                        break;
                    }
                    else
                    {
                        throw new FormatException("Wrong Trainee Id..Try Again");
                    }
                }
                catch(FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                    checkId = false;
                }
            }
            while (checkId == false);
            Console.WriteLine("Enter trainee name: ");
            traineeName = Console.ReadLine();

            Console.WriteLine("Enter batch code: ");
            string batchCode = Console.ReadLine();
            int traineeCount = 0;
            bool checkTraineeCount = false;
            do
            {
                Console.WriteLine("Enter number of trainees: ");
                traineeCount = int.Parse(Console.ReadLine());
                string message = ValidationTraineeCount.ValidateTraineeCount(traineeCount);
                if(message==null)
                {
                    checkTraineeCount = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Trainee Count>=30..Try Again");
                    checkTraineeCount = false;
                }
            }
            while (checkTraineeCount == false);
            Console.WriteLine("Enter company name: ");
            string company = Console.ReadLine();

            //pass data to parameterized constructor of trainee
            tr = new Trainee(company,batchCode,traineeCount,id, traineeName);

            //Output data vai class object
<<<<<<< HEAD
            tr.AcademyRule();
            tr.BusinessUnitRule();
=======
>>>>>>> 92e668f7065a9cd8b058142a609e80a70193b812
            tr.CompanyInfo();
            tr.BatchRule();
            Console.WriteLine(tr);

        }
    }
}
