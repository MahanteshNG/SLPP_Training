using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Method overloading is the process by which we can declare multiple methods with same name 
 * but differentiate between them either by supplying different number of arguments or
 * using diffrent datatype.
 * Method Overloading implements Static Polymorhism or Early Binding */

namespace Method_Overloading
{
    class Program
    {
        static void Add(int a)
        {
            Console.WriteLine("Single Int Type Addition is: " + (a + 10));
        }
        static void Add(float a)
        {
            Console.WriteLine("\nSingle Float Type Addition is: " + (a + 10.23F));
        }
        static void Add(int a,int b)
        {
            Console.WriteLine("\nAddition between 2 numbers is: " + (a + b));
        }
        static void Main(string[] args)
        {
            Add(10);
            Add(20.35F);
            Add(20, 40);
        }
    }
}
