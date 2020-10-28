using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Static Polymorphism or Early Binding */
namespace Method_Overloading
{
    class Program
    {
        /* First Method Second Method Displays Overloading as both names are same
         * but difference by number of arguments */
        static void Display()
        {
            Console.WriteLine("Welcome User");
        }
        static void Display(int a)
        {
            Console.WriteLine("Addition with Single int number as Arg: " + (a + 20));
        }
        /* Third Method Second Method Displays Overloading as both names are same
         * but difference by datatypes of arguments */
        public static void Display(float a)
        {
            Console.WriteLine("Addition with Single float number as Arg: " + (a + 20.56f));
        }
        static void Main(string[] args)
        {
            Display();
            Display(10);
            Display(10.58f);
        }
    }
}
