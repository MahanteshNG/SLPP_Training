using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        static void Main(string[] args) //calling code
        {
            //Create the class object and initialize it with new keyword
            Demo demo = new Demo();
            Console.WriteLine("Enter Company Name:");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter Global Head Quarter:");
            string headOffice = Console.ReadLine();
            Console.WriteLine("Enter Monthly Revenue:");
            double revenue = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of Subjects: ");
            int count = int.Parse(Console.ReadLine());
            double[] marks = new double[count];
            Console.WriteLine("Enter Array Marks:");
            for(int i=0;i<count;i++)
            {
                marks[i] = double.Parse(Console.ReadLine());
            }
            double avgMarks=Demo.TraineeAvgMarks(marks, count);

            Console.WriteLine("\n\nOutput.....");
            demo.CompanyInformation(companyName,headOffice);
            Console.WriteLine("Annual Revenue: " + demo.AnnualRevenue(revenue));
            Console.WriteLine("Avg Trainee Marks: " + avgMarks);
            
        }
    }
}
