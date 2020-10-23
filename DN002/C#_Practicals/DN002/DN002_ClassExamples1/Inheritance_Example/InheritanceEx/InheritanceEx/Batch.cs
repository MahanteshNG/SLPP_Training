using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{
    public class Batch:Company
    {
        public string BatchId { get; set; }
        public int TraineeCount { get; set; }
        public Batch()
        {

        }
        public Batch(string companyName,string batchId, int traineeCount):base(companyName)
        {
            BatchId = batchId;
            TraineeCount = traineeCount;
        }

        public override string ToString()
        {
            return string.Format("\nBatch Id: {0}\nNumber of Trainees: {1}",
                this.BatchId, this.TraineeCount);
        }

        public override void BatchRule()
        {
            Console.WriteLine("Each batch has to have a batch owner");
        }
    }

   public class ValidationTraineeCount
    {
        public static string ValidateTraineeCount(int traineeCount)
        {
            return traineeCount >= 30 ? null : "Incorrect Trainee Number";
        }
    }
}
