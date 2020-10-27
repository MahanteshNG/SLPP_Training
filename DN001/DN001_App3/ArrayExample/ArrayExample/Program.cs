using System;
//Namespace to add Non Generic Collection
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] arr = new int[5];
            for(int i=0;i<5;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nDisplay Array: ");
            for(int i=0;i<5;i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            */

            //ArrayList: Non Generic Class
            ArrayList PinCodeList = new ArrayList();
            //Property: Count [This property is used to find the size of a collection]
            Console.WriteLine("Initial Size of ArrayList: " + PinCodeList.Count);
            //Add(): This method of collection is used to add records to collection
            //New Records are added to end of collection
            PinCodeList.Add(713212);
            PinCodeList.Add(713214);
            PinCodeList.Add(713213);
            PinCodeList.Add(713211);
            PinCodeList.Add(1.23F); //Wrong Data
            PinCodeList.Add("Hallo"); //Wrong Data
            Console.WriteLine("\nSize of ArrayList After Data Addition: " + PinCodeList.Count);
            //Check if the data is existing in the collection
            //Contains(): This method checks if searched data is present in collection
            //and gives bool result true or false
            if (PinCodeList.Contains(713213))
            {
                PinCodeList.Remove(713213);
                Console.WriteLine("\nSize of ArrayList After Data Removal: " + PinCodeList.Count);
                Console.WriteLine("\nOutput ArrayList: ");
                //In Collections the starting index like array is 0
                //Way 1
                /*
                for(int i=0;i<PinCodeList.Count;i++)
                {
                    Console.WriteLine(PinCodeList[i]);
                }
                */
                //Way 2
                //foreach loop: This loop will go inside collection; extract the data from
                //collection one by one via element itself and then display the collection
                foreach(var data in PinCodeList)
                {
                    Console.WriteLine(data);
                }
            }
        }
    }
}
