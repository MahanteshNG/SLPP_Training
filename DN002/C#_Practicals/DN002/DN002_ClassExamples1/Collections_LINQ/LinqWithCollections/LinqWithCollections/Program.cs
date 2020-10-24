using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>
            {
                10,5,4,1,14,17,25,21,20
            };
            //Max() and Min() Methods of Linq
            Console.WriteLine("Greatest Number: "+li.Max());
            Console.WriteLine("\nSmallest Number: "+li.Min());

            Console.WriteLine("\nDisplay Odd Numbers from list in descending order:");
            //LINQ Query
            var oddNos = (from data in li
                          where data % 2 != 0
                          orderby data descending
                          select data).ToList();
            foreach(var x in oddNos)
                {
                Console.WriteLine(x);
                }

            Console.WriteLine("\nDisplay Even Numbers from list in descending order:");
            //Lamda Exression
            var evenNos = li.Where(data => data % 2 == 0).OrderByDescending(data => data)
                          .Select(data => data).ToList();
            foreach (var x in evenNos)
            {
                Console.WriteLine(x);
            }
        }
    }
}
