using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Trainee:Coach
    {        
        public int TraineeId { get; set; }
        public string TraineeName { get; set; }
        public string BatchCode { get; set; }
        
        public Trainee()
        {
                
        }
        public Trainee(int coachId, string coachName,int traineeId, string traineeName, 
            string batchCode):base(coachId,coachName)
        {
            TraineeId = traineeId;
            TraineeName = traineeName;
            BatchCode = batchCode;
        }
        /*
        public void DisplayTrainee()
        {
            Console.WriteLine("Trainee Id: " + TraineeId + "\nTrainee Name: " + TraineeName +
                "\nBatch Code: " + BatchCode);
        }*/

        public override string ToString()
        {
            return string.Format("Trainee Name:  {0}\nTrainee Id: {1}\nBatch Code: {2}\n{3}",
                TraineeName, TraineeId, BatchCode, new Coach(CoachId,CoachName));
        }
    }
}
