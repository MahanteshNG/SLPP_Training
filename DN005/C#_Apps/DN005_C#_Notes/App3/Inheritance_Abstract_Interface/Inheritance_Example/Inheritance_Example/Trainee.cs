using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    public class Trainee:Coach,CognizantContract,AcademyContract
    {
        //class members
        private int _traineeId;
        private string _traineeName;
        private string _batchCode;
        //properties
        public int TraineeId { get => _traineeId; set => _traineeId = value; }
        public string TraineeName { get => _traineeName; set => _traineeName = value; }
        public string BatchCode { get => _batchCode; set => _batchCode = value; }
        public Trainee()
        {

        }

        public Trainee(int _coachId,string _coachName,int traineeId, string traineeName, 
            string batchCode):base(_coachId,_coachName)
        {
            _traineeId = traineeId;
            _traineeName = traineeName;
            _batchCode = batchCode;
        }

       /* public override string ToString()
        {
            return string.Format("{0}\nTrainee Id: {1}\nTrainee Name: {2}\nBatch Code: {3}",
               new Coach(CoachId,CoachName), this.TraineeId, this.TraineeName,this.BatchCode);
        }*/

        public void DisplayTrainee()
        {
            Console.WriteLine("Trainee Id: {0}\nTrainee Name: {1}\nBatch Code: {2}",
               this.TraineeId, this.TraineeName, this.BatchCode);
        }

        public override bool TraineeResult(float[] marks, int size)
        {
            float sum = 0;
            for(int i=0;i<size;i++)
            {
                sum += marks[i];
            }

            if (sum / size >= 70)
                return true;
            else
                return false;
        }

        public void JoiningRule()
        {
            Console.WriteLine("Stage 1 passing manditory to join Cognizant Academy for Stage2");
        }

        public void AcademyRule()
        {
            Console.WriteLine("Clearance of Stage2 and MFRP Project manditory to join BU");
        }
    }
}
