using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace for making date neutral of region and culture
using System.Globalization;

namespace ClassObject_Demo1
{
    class Program
    {
        //To debug your program press F11 from keyboard
        static void Main(string[] args)
        {
            TraineeModel model = new TraineeModel();
            Console.WriteLine("Enter Trainee Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Trainee Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Date of Joining(dd/MM/yyyy): ");
            DateTime doj = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", 
                CultureInfo.InvariantCulture);
            //pass data to model class
            model = new TraineeModel(id, name, doj);
            Console.WriteLine("\n\nTrainee Name: " + model.TraineeName +
                "\nTrainee Id: " + model.Id + "\nJoining Date: " +
                model.DateofJoining.ToString("dd.MM.yyyy"));
        }
    }
}
