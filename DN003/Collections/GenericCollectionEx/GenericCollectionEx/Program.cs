using System;
//Namespace for Generic Collection
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            /*************Generic Collection****************/
            //List
            /*
            List<int> PinCodeList = new List<int>();
            string listInput = string.Empty;
            Console.WriteLine("Add List Records:");
            do
            {
                PinCodeList.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Press Yes to continue..Any other to stop:");
                listInput = Console.ReadLine();
            }
            while (listInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("\nDisplay List Records:");
            foreach(var data in PinCodeList)
            {
                Console.WriteLine(data);
            }

            //Set
            SortedSet<string> countrySet = new SortedSet<string>();
            string setInput = string.Empty;
            Console.WriteLine("\nEnter Sorted Set Records:");
            do
            {
                countrySet.Add(Console.ReadLine());
                Console.WriteLine("Press Yes to continue..Any other to stop:");
                setInput = Console.ReadLine();
            }
            while (setInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("\nDisplay Sorted Set Records:");
            foreach (var data in countrySet)
            {
                Console.WriteLine(data);
            }
            */

            //Dictionary
            SortedDictionary<int, string> employeeDictionary = new SortedDictionary<int, string>();
            string dictionaryInput = string.Empty;
            Console.WriteLine("\nEnter Records in Sorted Dictioanry: ");
            do
            {
                employeeDictionary.Add(int.Parse(Console.ReadLine()), Console.ReadLine());
                Console.WriteLine("Press Yes to continue..Any other to stop:");
                dictionaryInput = Console.ReadLine();
            }
            while (dictionaryInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine("\nEnter the Id to search value:");
            int searchId = int.Parse(Console.ReadLine());
            if(employeeDictionary.ContainsKey(searchId))
            {
                Console.WriteLine("Employee Name: " + employeeDictionary[searchId]);
            }
            else
            {
                Console.WriteLine("Seached Employee not found");
            }

            Console.WriteLine("\nDisplay Sorted Set Records:");
            foreach (var data in employeeDictionary)
            {
                Console.WriteLine(data.Key+"-----"+data.Value);
            }
        }
    }
}
