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
            List<int> list = new List<int>()
            {
                10,1,15,17,2,14,12,11,9
            };
            //Max() and Min() Linq Methods with Collection helps to find the largest
            //and smallest number present in collection
            Console.WriteLine("Greatest Number: " + list.Max());
            Console.WriteLine("\nSmallest Number: " + list.Min());

            //Filter and display all even numbers present in the collection in descending manner
            //Linq Query
            var evenNos = (from data in list
                           where data % 2 == 0
                           orderby data descending
                           select data).ToList();
            //Console.WriteLine("\nevenNos variable datatype: " + evenNos.GetType());
            Console.WriteLine("\nEven No Display:");
            foreach(var x in evenNos)
            {
                Console.WriteLine(x);
            }
            //Lamda Expression
            Console.WriteLine("\nDisplay Odd Numbers in descending manner:");
            var oddNos = list.Where(data => data % 2 != 0).OrderByDescending(data => data)
                            .Select(data => data).ToList();
            foreach(var x in oddNos)
            {
                Console.WriteLine(x);
            }
        }
    }
}
