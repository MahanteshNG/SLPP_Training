using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class Demo
    {
        /* Instance Methods */
        //Non Return Method
        public void CompanyInformation(string name,string ho)
        {
            Console.WriteLine("Company Name: " + name);
            Console.WriteLine("Head Office: " + ho);
        }
        /* Instance Methods */
        //Return Method
        public double AnnualRevenue(double monthlyRevenue)
        {
            return monthlyRevenue * 12;
        }

        /* Static Method */
        public static double TraineeAvgMarks(double[] arr,int subjectNo)
        {
            double sum = 0;
            double avg = 0;
            for(int i=0;i<subjectNo;i++)
            {
                sum += arr[i];
            }
            avg = sum / subjectNo;
            return avg;
        }
    }
}
