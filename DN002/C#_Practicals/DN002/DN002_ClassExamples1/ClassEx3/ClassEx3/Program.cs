using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach Coach = new Coach();
            Console.WriteLine("Enter Coach Id: ");
            Coach.CoachId = Console.ReadLine();
            Console.WriteLine("Enter Coach Name: ");
            Coach.CoachName = Console.ReadLine();

            Console.WriteLine("\nName: " + Coach.CoachName + "\nId: " + Coach.CoachId);
        }
    }
}
