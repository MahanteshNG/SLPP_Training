using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace
using System.Data;

namespace CRUDDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = new Operation();
            DataTable table = op.DisplayAllTrainees();
            if (table.Rows.Count > 0) //ie data is present under data table
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3}", "Trainee Id", "Trainee Name",
                    "Batch Code", "Date Of Joining");
                foreach(DataRow row in table.Rows)
                {
                    DateTime dt = DateTime.Parse(row["DateOfJoining"].ToString());
                    Console.WriteLine("{0,-20}{1,-20}{2,-20}{3}",
                        row["TraineeId"].ToString(),row["TraineeName"].ToString(),
                        row["BatchCode"].ToString(),dt.ToString("dd-MM-yyyy"));
                    
                }
            }
            else
            {
                Console.WriteLine("No data is present to display");
            }
        }
    }
}
