using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading_Example
{
    class THreading_Reflection
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Trainee Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Trainee Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Mobile Number: ");
            /*double? phoneNumber = null;
            //phoneNumber = 9600197754;*/
            double phoneNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("\n\nLoading Output......");
            //Thread 
            System.Threading.Thread.Sleep(5000);
            
            Console.WriteLine("Name: " + name+"  Datatype: "+name.GetType());
            Console.WriteLine("Id: " + id + "  Datatype: " + id.GetType());
            Console.WriteLine("Phone Number: "+phoneNumber + "  Datatype: " + phoneNumber.GetType());
        }
    }
}
