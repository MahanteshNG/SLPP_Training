using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace for Regex
using System.Text.RegularExpressions;

namespace CrudExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TraineeDL tr = new TraineeDL();
            TraineeDataOperation operaion = new TraineeDataOperation();
            string loopInput = string.Empty;
            string loopEntry = string.Empty;
            do
            {
                Console.WriteLine("Enter Menu:\n1. Insert Record\n2. Display Record"+
                    "\n3. Display By Search Trainee Id\n4. Display By Searched Department Code");
                int menu = int.Parse(Console.ReadLine());
                switch(menu)
                {
                    case 1:
                        do
                        {
                            try
                            {
                                Console.WriteLine("Enter Employee Name:");
                                string name = Console.ReadLine();
                                //Batch Code should be in below format:
                                //XXXXYYZZPPP where X is alphabets in capital,Y is number
                                //Z is alphabet in capital,P is number
                                //example:SLPP20DN005 -> correct; slppDN005 or SLPP005DN20- >wrong
                                string pattern = @"^[A-Z]{4}[0-9]{2}[A-Z]{2}[0-9]{3}$";
                                string batchCode = string.Empty;
                                bool patternCheck = false;
                                do
                                {
                                    Console.WriteLine("Enter Batch Code:");
                                    batchCode = Console.ReadLine();
                                    patternCheck = Regex.IsMatch(batchCode, pattern);
                                    if(patternCheck==false)
                                    {
                                        Console.WriteLine("Batch Code Wrong..Try Again");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                while (patternCheck == false);
                                Console.WriteLine("Enter Date of Joining (in dd/MM/yyyy):");
                                DateTime doj = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                                tr = new TraineeDL(name, batchCode, doj);
                                bool result = operaion.AddRecord(tr);
                                if(result==true)
                                {
                                    Console.WriteLine("Data Successfully Inserted");
                                }
                                else
                                {
                                    throw new Exception("Data Insertion failed");
                                }
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        while (loopEntry.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
                        break;

                    case 2:
                        List<TraineeDL> storageList = operaion.DisplayAllTraineesInfo();
                        if(storageList.Count>0) //data is present list
                        {
                            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3}", "Trainee Id",
                                "Trainee Name", "Batch Code", "Date of Joining");
                            foreach(var data in storageList)
                            {
                                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3}",
                                    data.TraineeId, data.TraineeName, data.BatchCode,
                                    data.DateOfJoining.ToString("dd-MM-yyyy"));
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is no data under the table for display");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter Trainee Id to search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        TraineeDL searchedTrainee = operaion.SearchById(searchId);
                        if(searchedTrainee!=null) //ie data is found
                        {
                            Console.WriteLine("Trainee Name: " + searchedTrainee.TraineeName);
                            Console.WriteLine("Batch Code: " + searchedTrainee.BatchCode);
                        }
                        else
                        {
                            Console.WriteLine("No Trainee with searched id found");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter Batch Code to search:");
                        string searchCode = Console.ReadLine();
                        List<TraineeDL> dislayByDepartment = operaion.DisplayTraineeByDepartment(searchCode);
                        if (dislayByDepartment.Count > 0) //data is present list
                        {
                            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3}", "Trainee Id",
                                "Trainee Name", "Batch Code", "Date of Joining");
                            foreach (var data in dislayByDepartment)
                            {
                                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3}",
                                    data.TraineeId, data.TraineeName, data.BatchCode,
                                    data.DateOfJoining.ToString("dd-MM-yyyy"));
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is no data under the table for searched batch code");
                        }
                        break;
                }
                Console.WriteLine("Press yes to continue..Any other key to stop:");
                loopInput = Console.ReadLine();
            }
            while (loopInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
