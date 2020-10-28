using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

    public class Program
    {
        public static void Main(string[] args)
        {
        ArrayList myList = new ArrayList();
        string te;


        StreamReader sr = new StreamReader(@"input.csv");
        while (!sr.EndOfStream)
        {
            te = sr.ReadLine();
            string[] spl = te.Split(',');
            string mop = spl[2].Trim();
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime dt = DateTime.ParseExact(mop, "dd-mm-yyyy", provider);

            //Product p = new Product(spl[0], spl[1], dt, double.Parse(spl[3]));

            myList.Add(new Product(spl[0], spl[1], dt, double.Parse(spl[3])));

        }
        sr.Close();
        Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "Product Name", "Serial Number", " Purchase Date", " Purchase Cost");
        foreach (Product s in myList)
        {
            Console.WriteLine(s);
        }
    }
}
    

