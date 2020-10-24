using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee tr = new Trainee();
            Console.WriteLine("Enter Trainee Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Trainee Name: ");
            string name = Console.ReadLine();
            tr = new Trainee(id, name);

            Console.WriteLine("\nData Output");
            Console.WriteLine(tr);
        }
    }
}
