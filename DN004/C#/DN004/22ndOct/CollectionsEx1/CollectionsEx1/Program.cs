using System;
using System.Collections;
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
            //Note: All methods of List<T> and ArrayList is same
            ArrayList TraineeIdList = new ArrayList();
            //Add() method will allow data to enter to collection where new data is always
            //added to end of collection
            TraineeIdList.Add(1001);
            TraineeIdList.Add(1002);
            TraineeIdList.Add("Hallo");   //False value or Wrong Value

            List<int> PinCodeList = new List<int>();
            //Count Property is used to find the size of List or ArrayList
            Console.WriteLine("Size of List before data insertion: " + PinCodeList.Count);
            PinCodeList.Add(713212);
            PinCodeList.Add(603110);
            //PinCodeList.Add("Hi");   Not allowed
            PinCodeList.Add(603105);
            PinCodeList.Add(603104);
            PinCodeList.Add(713214);
            PinCodeList.Add(603106);
            PinCodeList.Add(603105);
            Console.WriteLine("\nSize of List after data insertion: " + PinCodeList.Count);
            PinCodeList.Remove(603104);
            Console.WriteLine("\nSize of List after deleting data: " + PinCodeList.Count);
            //Sort Data from List in Descending Manner
            PinCodeList.Sort();
            PinCodeList.Reverse();
            /* foreach() will look to the elements inside the array or collection
             * and extract data directly from array or collection by element name */
            Console.WriteLine("\nList Output:");
            foreach (var data in PinCodeList)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine("\n\nEnter Elements in Countries Sorted Set:");
            SortedSet<string> CountrySet = new SortedSet<string>();
            string loopInput = string.Empty;
            do
            {
                CountrySet.Add(Console.ReadLine());
                Console.WriteLine("Press yes to continue...any other key to terminate: ");
                loopInput = Console.ReadLine();
            }
            while (loopInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine("\nSorted Set Output:");
            foreach (var data in CountrySet)
            {
                Console.WriteLine(data);
            }

            SortedDictionary<int, string> EmployeeList = new SortedDictionary<int, string>();
            Console.WriteLine("\n\nEnter Data to Employee Dictionary: ");
            string loopInput1 = string.Empty;
            do
            {
                EmployeeList.Add(int.Parse(Console.ReadLine()), Console.ReadLine());
                Console.WriteLine("Press yes to continue...any other key to terminate: ");
                loopInput1 = Console.ReadLine();
            }
            while (loopInput1.Equals("yes", StringComparison.InvariantCultureIgnoreCase));

            foreach (var data in EmployeeList)
            {
                Console.WriteLine(data.Key+"---"+data.Value);
            }

        }
    }
}
