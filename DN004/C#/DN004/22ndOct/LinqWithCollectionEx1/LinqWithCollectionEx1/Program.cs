using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithCollectionEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
               13,15,2,17,9,5,14,8,24,22
            };

            Console.WriteLine("Max value in List: "+li.Max());
            Console.WriteLine("\nMin value in List: "+li.Min());

            //LINQ Query to extract odd data under collection
            Console.WriteLine("\nOdd Data in Collection: ");
            var oddNumber = (from data in li where data % 2 != 0
                             orderby data descending select data).ToList();
            foreach(var x in oddNumber)
            {
                Console.WriteLine(x);
            }
            //Lamda Expression to extract even numbers from collection in descending manner
            Console.WriteLine("\nEven Data in Collection: ");
            var evenNumber = li.Where(x => x % 2 == 0).OrderByDescending(x=>x)
                .Select(x => x).ToList();
            foreach(var data in evenNumber)
            {
                Console.WriteLine(data);
            }
        }
    }
}
