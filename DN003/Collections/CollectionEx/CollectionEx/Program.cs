using System;
//Namespace for Non-Generic Collection
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Count-> This proporty of Collection Class will find the tot al size of Collection
 * Add() -> This method will insert new elements to collection
 * Contains()->This method will check if searched data is present and give bool value as result
 * Remove()->It will remove a data from collection
 * */

namespace CollectionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            /***************Non Generic Collection*************/
            ArrayList PincodeList = new ArrayList();
            Console.WriteLine("Initial Size of Collection: " + PincodeList.Count);
            //Add records to collection
            PincodeList.Add(713212);
            PincodeList.Add(713214);
            PincodeList.Add(713212);
            PincodeList.Add(713213);
            PincodeList.Add(713211);
            PincodeList.Add(1.23F); //Wrong Data
            PincodeList.Add("Hallo"); //Wrong Data
            Console.WriteLine("\nSize of Collection after data insert: " + PincodeList.Count);
            Console.WriteLine("\nEnter Pin Code to Search and Remove: ");
            int search = int.Parse(Console.ReadLine());
            if(PincodeList.Contains(search))
            {
                PincodeList.Remove(search);
                Console.WriteLine("\nSize of Collection after data removal: " + PincodeList.Count);
            }
            else
            {
                Console.WriteLine("Searched Pin Code does not exist");
            }

            Console.WriteLine("\nOutput Collection Data:");
            /* foreach loop:This loop will enter the collection and search data from collection
             * directly by element name[and not the index] one by one and then extract the 
             * data for output or any other operations
             * 
             * var key:Implicit Type local variable that can represent any datatype. So we use
             * this during design time to keep the programming light-weight for faster compilation
             * */
             foreach(var data in PincodeList)
            {
                Console.WriteLine(data);
            }
             
        }
    }
}
