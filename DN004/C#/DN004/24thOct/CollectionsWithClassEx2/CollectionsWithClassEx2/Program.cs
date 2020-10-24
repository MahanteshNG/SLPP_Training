using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsWithClassEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainee> TraineeList = new List<Trainee>();
            Trainee trainee = new Trainee();
            string loopInput = string.Empty;
            do
            {
                Console.WriteLine("Enter Trainee Id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Trainee Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Degree:");
                string degree = Console.ReadLine();

                trainee = new Trainee(id, name, degree);
                //Add the trainee object to the list
                TraineeList.Add(trainee);
                Console.WriteLine("Enter yes to continue..any other key to stop:");
                loopInput = Console.ReadLine();
                Console.WriteLine();
            }
            while(loopInput.Equals("yes",StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine("\nDisplay All Trainees:");
            Console.WriteLine("{0,-20}{1,-20}{2}", "Trainee Id", "Trainee Name", "Degree");
            List<Trainee> returnList = Utility.DisplayAllTrainees(TraineeList);
            foreach(var data in returnList)
            {
                Console.WriteLine("{0,-20}{1,-20}{2}", data.TraineeId, data.TraineeName, data.Degree);
            }

            Console.WriteLine("\nDisplay Trainee belonging to searched department:");
            Console.WriteLine("Enter the department to search:");
            string searchDept = Console.ReadLine();
            List<Trainee> returnList1 = Utility.DisplayAllTrainees(TraineeList, searchDept);
            if(returnList1.Count>0) //ie searchDept is found and trainee results are extracted
            {
                Console.WriteLine("{0,-20}{1,-20}{2}", "Trainee Id", "Trainee Name", "Degree");
                foreach (var data in returnList1)
                {
                    Console.WriteLine("{0,-20}{1,-20}{2}", data.TraineeId, data.TraineeName, data.Degree);
                }
            }
            else
            {
                Console.WriteLine("Searched Dept does not exist");
            }

            Console.WriteLine("\nDisplay Trainee Info via Id:");
            Console.WriteLine("Enter Id to search:");
            int searchId = int.Parse(Console.ReadLine());
            Trainee store = Utility.DisplayTraineeById(TraineeList, searchId);
            if(store!=null) //ie searchId matches with List Trainee id
            {
                Console.WriteLine("{0,-20}{1,-20}{2}", "Trainee Id", "Trainee Name", "Degree");
                Console.WriteLine("{0,-20}{1,-20}{2}", store.TraineeId, 
                    store.TraineeName, store.Degree);
            }
            else
            {
                Console.WriteLine("Searched Trainee Id does not exist");
            }
        }
    }
}
