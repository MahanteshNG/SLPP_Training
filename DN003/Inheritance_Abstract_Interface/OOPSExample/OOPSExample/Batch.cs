using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample
{
    public abstract class Batch
    {
        public string BatchCode { get; set; }
        public Batch()
        {

        }

        public Batch(string batchCode)
        {
            BatchCode = batchCode;
        }

        public void BatchInfo()
        {
            Console.WriteLine("Batch Code: " + this.BatchCode);
        }

        public abstract double CoachSalary(double monthlySalary);
    }
}
