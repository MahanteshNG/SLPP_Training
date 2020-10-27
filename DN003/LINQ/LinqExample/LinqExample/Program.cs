using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                10,5,12,1,7,14,9,3,1,5,12,11
            };

            Console.WriteLine("Greatest Number in List: "+list.Max());
            Console.WriteLine("\nSmallest Number in the list: "+list.Min());

            Console.WriteLine("\nDisplay Distinct Odd Elements in Descending manner: ");
            //LINQ Query
            var oddData = (from data in list
                           where data % 2 != 0
                           orderby data descending
                           select data).ToList();
            foreach(var x in oddData.Distinct())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nDisplay Distinct Even Numbers from List in Descending Order:");
            //Lamda Expression
            var evenData = list.Where(data => data % 2 == 0).OrderByDescending(data => data)
                             .Select(data => data).ToList();
            foreach (var x in evenData.Distinct())
            {
                Console.WriteLine(x);
            }
        }
    }
}
