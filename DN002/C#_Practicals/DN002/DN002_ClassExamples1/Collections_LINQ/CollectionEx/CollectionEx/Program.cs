using System;
//Namespace for Non Generic Collection
using System.Collections;
//Namespace for Generic Collection
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Count -> This property is used to find the size of collection
 * Add() -> This property is used to insert new records to collection
 * Remove() -> This property is used to delete record from the collection
 * */
namespace CollectionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList RollNumberList = new ArrayList();
            Console.WriteLine("Size of ArrayList before data addition: " + RollNumberList.Count);
            RollNumberList.Add(1001);
            RollNumberList.Add(1002);
            RollNumberList.Add(1003);
            RollNumberList.Add(1.23F); //False data
            RollNumberList.Add("Hallo"); //False data
            Console.WriteLine("\nSize of ArrayList after data addition: " + RollNumberList.Count);
            RollNumberList.Remove(1002);
            Console.WriteLine("\nAfter data removal size of ArrayList: " + RollNumberList.Count);
            //forach loop: This loop will extract data one by one from collection for output
            //by directtly the elements
            Console.WriteLine("\nDisplay Array List:");
            foreach (var data in RollNumberList)
            {
                Console.WriteLine(data);
            }

            //List
            List<int> PinCodeList = new List<int>();
            string listInput = string.Empty;
            Console.WriteLine("\nEnter List Records:");
            do
            {
                PinCodeList.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter yes to continue..any other key to terminate:");
                listInput = Console.ReadLine();
            }
            while (listInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("\nDisplay Generic List:");
            foreach (var data in PinCodeList)
            {
                Console.WriteLine(data);
            }

            //Set
            SortedSet<string> CountrySet = new SortedSet<string>();
            string setInput = string.Empty;
            Console.WriteLine("\nEnter Sorted Set Data: ");
            do
            {
                CountrySet.Add(Console.ReadLine());
                Console.WriteLine("Enter yes to continue..any other key to terminate:");
                setInput = Console.ReadLine();
            }
            while (setInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("\nDisplay Generic List:");
            foreach (var data in CountrySet)
            {
                Console.WriteLine(data);
            }
            

            SortedDictionary<int, string> employeeDictionary = new SortedDictionary<int, string>();
            string dictionaryInput = string.Empty;
            Console.WriteLine("Enter data in Sorted Dictionary:");
            do
            {
                employeeDictionary.Add(int.Parse(Console.ReadLine()), Console.ReadLine());
                Console.WriteLine("Enter yes to continue..any other key to terminate:");
                dictionaryInput = Console.ReadLine();
            }
            while (dictionaryInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("\nDictionary Output:");
            //-20 or any minus value under index represents the space between 2 data
            Console.WriteLine("{0,-20}{1}", "Employee Id", "Employee Name");
            foreach(var data in employeeDictionary)
            {
                Console.WriteLine("{0,-20}{1}", data.Key, data.Value);
            }

        }
    }
}
