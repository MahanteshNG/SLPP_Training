using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExample2
{
    class TimeSpanExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Policy Start Date(in yyyy/MM/dd): ");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd",
                CultureInfo.InvariantCulture);

            Console.WriteLine("Enter Policy Maturity Date(in yyyy/MM/dd): ");
            DateTime maturityDate = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd",
                CultureInfo.InvariantCulture);

            //Check if maturity Date is greater tha current date
            if(maturityDate.CompareTo(startDate) >0) //ie maturity date is more than start date
                //CompareTo:
                //firstValue>Second Value  -- Output>0
                //firstValue==SecondValue --output=0
                //firstValye<Secondvalue ---outpu<0
            {
                //check if policy is 5 years old then output Matured; otherwise output Running
                //TimeSpan Class: This class is used if we want to find the interval between
                //2 date values. TimeSpan uses Substarct method to find the difference.
                //Timespan will give interval in number of days
                TimeSpan ts = maturityDate.Subtract(startDate);
                int isMatured = (int)ts.TotalDays / 365;              

                if(isMatured>=5)
                {
                    Console.WriteLine("Matured");
                }
                else
                {
                    Console.WriteLine("Runnig");
                }
            }
            else
            {
                Console.WriteLine("Maturty Date should be greater than plocy start date");
            }

        }
    }
}
