/* namespace */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    /* Namespace: System
     * Class Console -> Library Class
     Reading Function: ReadLine()
     Writing Function: Write() or WriteLine()
     */
    class Demo1Output //Executable class
    {
        /* Business Rule:
         * ID of trainee should be 4 digits; if anything more or less is
         * entered tell user "Invalid Id" and ask user to reenter Id again.
         * Salary should be rounded to 2 decimal places */

        /* ToString(): This method is used to convert numeric or DateTime data to string type
         * to use string formats and string functions */

        /* Type Cast string data that is coming by ReadLine method to be
            * stored under numeric variables.
            * Parse() method is used for type casting */
        static void Main(string[] args) //Executable method
        {
            Console.WriteLine("Enter Trainee Name:");
            string name=Console.ReadLine();
            int id = 0;
            bool checkIdValidity = false;
            do
            {
                Console.WriteLine("Enter Trainee Id:");
                id = int.Parse(Console.ReadLine());
                if(id.ToString().Length!=4)
                {
                    checkIdValidity = false;
                    Console.WriteLine("Invalid ID..Retry Again");
                }
                else
                {
                    checkIdValidity = true;
                    break;
                }
            }
            while (checkIdValidity == false);
            Console.WriteLine("Enter Trainee Salary:");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of Subjects the trainee has given exam:");
            int SubjectCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Input marks of all the subjects:");
            //datatype[] arrayobject=new datatype[dimension]
            float[] marks = new float[SubjectCount];
            //add data by array index
            for(int i=0;i<SubjectCount;i++)
            {
                marks[i] = float.Parse(Console.ReadLine());
            }
            //Calculate Average marks of the trainee
            double avgMarks = 0;
            double sum = 0;
            for(int i=0;i<SubjectCount;i++)
            {
                sum = sum + marks[i];
            }
            avgMarks = sum / SubjectCount;

            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Salary: " + salary.ToString("0.00"));
            Console.WriteLine("Trainee Average Score: " + avgMarks.ToString("0.00"));
            if(avgMarks>=85 && avgMarks<=100)
            {
                Console.WriteLine("Good Score");
            }
            else if(avgMarks>=70 && avgMarks<80)
            {
                Console.WriteLine("Fair Score");
            }
            else
            {
                Console.WriteLine("Trainee has to go for exam re-attempt");
            }
        }
    }
}
