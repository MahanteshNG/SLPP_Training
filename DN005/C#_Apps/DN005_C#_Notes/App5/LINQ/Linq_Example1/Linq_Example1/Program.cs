using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>
            {
                1,5,15,25,20,13,48,17
            };

            Console.WriteLine("Greatest Number: " + li.Max());

            Console.WriteLine("\n\nPrint Even Numbers from the collection:");
            //Linq Query [SQL Line Syntaxes in C# Lang]
            var evenNos = (from x in li where x % 2 == 0
                           orderby x descending select x).ToList();
            foreach(var data in evenNos)
            {
                Console.WriteLine(data);
            }
            /* Or Lamda Expression [Shortened LINQ Format] */
            /*data=>operation
             * => Lamda Operator */
            Console.WriteLine("\n\nPrint Odd elemets from collection in desc manner:");
            var oddNos = li.Where(x => x % 2 != 0).OrderByDescending(x => x).Select(x => x).ToList();
            foreach(var data in oddNos)
            {
                Console.WriteLine(data);
            }

        }
    }
}
