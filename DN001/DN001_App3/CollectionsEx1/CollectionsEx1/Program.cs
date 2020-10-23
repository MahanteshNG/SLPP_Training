using System;
//Namepace for Generic Collection Class
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> PinCodeList = new List<int>();
            Console.WriteLine("Inital Size of List: " + PinCodeList.Count);
            string listInput = string.Empty;
            Console.WriteLine("\nEnter List Data:");
            do
            {
                PinCodeList.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Do you want to enter again(Enter yes):");
                listInput = Console.ReadLine();
            }
            while (listInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("\nSize of List after Data Addition: " + PinCodeList.Count);
            Console.WriteLine("List Output:");
            foreach(var data in PinCodeList)
            {
                Console.WriteLine(data);
            }

            //Set
            SortedSet<string> CountrySet = new SortedSet<string>();
            Console.WriteLine("\nEnter data to Set:");
            string setInput = string.Empty;
            do
            {
                CountrySet.Add(Console.ReadLine());
                Console.WriteLine("Do you want to enter again(Enter yes):");
                setInput = Console.ReadLine();
            }
            while (setInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("\nDisplay Set Data:");
            foreach(var data in CountrySet)
            {
                Console.WriteLine(data);
            }
            */
            //Dictionary
            SortedDictionary<int, string> EmployeeDictionary = new SortedDictionary<int, string>();
            string dictionaryInput = string.Empty;
            Console.WriteLine("\nEnter Dictionary Data:");
            do
            {
                EmployeeDictionary.Add(int.Parse(Console.ReadLine()), Console.ReadLine());
                Console.WriteLine("Do you want to enter again(Enter yes):");
                dictionaryInput = Console.ReadLine();
            }
            while (dictionaryInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
            //-20 or any other values with give the equivalent space between 2 data
            Console.WriteLine("\nDictionary Output:");
            Console.WriteLine("{0,-20}{1}", "Employee Id", "Employee Name");
            foreach(var data in EmployeeDictionary)
            {
                Console.WriteLine("{0,-20}{1}", data.Key, data.Value);
            }
        }
    }
}
