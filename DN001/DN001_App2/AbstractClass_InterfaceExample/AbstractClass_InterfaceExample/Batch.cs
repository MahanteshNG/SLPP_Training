using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceExample
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
            Console.WriteLine("\nBatch Code: " + this.BatchCode);
        }
        public abstract double TraineeAnnualSalary(double monthlySalary);
    }
}
