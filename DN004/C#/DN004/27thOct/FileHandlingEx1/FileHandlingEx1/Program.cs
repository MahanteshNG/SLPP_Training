using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a txt file and pre-fill some data under the file. Now use a StreamReader class
//to read data from file and output it in output window
using System.IO;
using System.Globalization;

namespace FileHandlingEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream Class(location,FileMode.OpenOrCreate,FileAccess.Read)
            FileStream fs = new FileStream(@"C:\Users\kaushik\Desktop\SLPPDN003\DN003\C#\DN003\LINQ\FileHandlingEx1\FileHandlingEx1\EmployeeDetails.csv",
                FileMode.OpenOrCreate, FileAccess.Read);
            List<EmployeeDL> li = new List<EmployeeDL>();
            EmployeeDL dl = new EmployeeDL();
            using (StreamReader reader = new StreamReader(fs))
            {
                string info = string.Empty;
                //read data till you encounter null value
                while((info=reader.ReadLine())!=null)
                {
                    string[] datainfo = info.Split(',');
                    dl = new EmployeeDL(int.Parse(datainfo[0]), datainfo[1],
                        DateTime.ParseExact(datainfo[2], "dd-MM-yyyy", CultureInfo.InvariantCulture),
                        double.Parse(datainfo[3]));
                    //Add the class object to List
                    li.Add(dl);
                }
            }
            fs.Close();
            Console.WriteLine("Output:");
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3}", "Employee Id", "Employee Name",
                "Joining Date", "Salary");
            foreach(var employee in li)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("Read Operation Completed");
            //Stop the Write Operation Starting for 5000 millisecond ie 5 sec and then start writing
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("\nWrite your information about employees seperated by , symbol: ");
            string employeeInput = Console.ReadLine();
            FileStream fs1 = new FileStream(@"C:\Users\kaushik\Desktop\SLPPDN003\DN003\C#\DN003\LINQ\FileHandlingEx1\FileHandlingEx1\EmployeeDetails.csv",
                FileMode.Append, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs1))
            {
                //writer.WriteLine();
                writer.WriteLine(employeeInput);
                writer.Flush();
            }
            fs1.Close();

        }
    }
}
