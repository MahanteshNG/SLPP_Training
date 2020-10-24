using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx1
{
    class Program  //Executable class or UI class
    {
        //To debug your program enter a breakpoint and start pressing F11 from keyboard
        static void Main(string[] args) //Executable method
        {
            //Create and initialize a class object
            TraineeDl Dl = new TraineeDl();

            Console.WriteLine("Enter Trainee Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Trainee Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Trainee Average Marks: ");
            double avgMarks = double.Parse(Console.ReadLine());

            //Call paramaterized constructor and pass data to model class
            Dl = new TraineeDl(id, name, avgMarks);

            Console.WriteLine("\nName: " + Dl.Name + "\nId: " + Dl.Id + "\nMarks: " +
                Dl.AverageMarks.ToString("0.00"));
        }
    }
}
