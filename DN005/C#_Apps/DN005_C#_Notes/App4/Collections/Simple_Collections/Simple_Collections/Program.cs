using System;
/* namespace for non generic collection */
using System.Collections;
/* namespace for generic collection */
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Collections: Classes implementing IEnurable Interface
 * (i) Non Generic Collection like ArrayList [No datatype constraint we can add any values.
 * Drawback: Not Type Safe and Performance Issue]
 * (ii) Generic Collection like List<T>, Set<T> and Dictionary<T,T> [In Generic Collection we
 * provide Datatype Constraints <T> to ensure correct values get inside collection]
 * */

namespace Simple_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList BookIdList = new ArrayList();
            //Add records
            BookIdList.Add(1001);
            BookIdList.Add(1002);
            BookIdList.Add("Sam");

            Console.WriteLine("ArrayList Data:");
            foreach(var x in BookIdList)
            {
                Console.WriteLine(x);
            }

            List<int> TraineeIdList = new List<int>();
            TraineeIdList.Add(5001);
            TraineeIdList.Add(5002);
            TraineeIdList.Add(5001);
            //TraineeIdList.Add("Sam");
            Console.WriteLine("\nSize of List after adding records: " + TraineeIdList.Count);
            Console.WriteLine("Display List Records:");
            foreach(var x in TraineeIdList.Distinct())
            {
                Console.WriteLine(x);
            }

            /* HashSet and SortedSet -> Do not duplicate value for storage */
            SortedSet<string> TraineeNameList = new SortedSet<string>();
            TraineeNameList.Add("Joe");
            TraineeNameList.Add("Anand");
            TraineeNameList.Add("Kelvin");
            TraineeNameList.Add("Anand");
            TraineeNameList.Add("Deb");

            Console.WriteLine("\n\nSorted Set Output:");
            foreach(var x in TraineeNameList)
            {
                Console.WriteLine(x);
            }

            /* Dictionary<Key,value> and SortedDictioanry<Key,value> */
            SortedDictionary<int, string> CoachList = new SortedDictionary<int, string>();
            CoachList.Add(7003, "Merry");
            CoachList.Add(7001, "Kiranmayee");
            CoachList.Add(7002, "Thomas");
            Console.WriteLine("\n\nDictionary Output:");
            foreach(KeyValuePair<int,string> x in CoachList)
            {
                Console.WriteLine("Coach Id: " + x.Key + "   Coach Name: " + x.Value);
            }
        }
    }
}
