using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace
using System.Globalization;

namespace DateTimeAPI
{
    class DateTimeEx1
    {
        static void Main(string[] args)
        {
            /*
            DateTime curDateTime = DateTime.Now;
            Console.WriteLine("Default date and time: " + curDateTime);
            //Dispaly current as example: Wednesday,20 Septmber,2020
            Console.WriteLine("\nFormatted Current Date: " +
                curDateTime.ToString("dddd,dd MMMMM,yyyy"));*/

            //DateTime.ParseExact(string input,string pattern,CultureInfo.InvariantCulture)
            //To Use CultureInfo.InvariantCulture add namespace System.Globization
            DateTime dob;
            bool checkDob = true;
            do
            {
                try
                {
                    Console.WriteLine("Enter date of birth (in dd/MM/yyyy format): ");
                    dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Console.WriteLine("Trainee Dob: " + dob.ToString("dd.MM.yy"));
                    checkDob = true;
                }
                catch (FormatException fe)
                {
                    //Display the name of exception class at runtime
                    //Reflection in C# is uses to get info about classes,datatype,methods,properties
                    //etc at runtime
                    //example of Reflection Method: GetType()
                    checkDob = false;
                    Console.WriteLine(fe.GetType().Name);
                    Console.WriteLine("Exception Occured..Date should be in dd/MM/yyyy format for entry");
                    Console.WriteLine("Restart your date Entry:\n");
                }
            }
            while (checkDob == false);

            Console.WriteLine("Enter Department Name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Department: " + deptName);
        }
    }
}
