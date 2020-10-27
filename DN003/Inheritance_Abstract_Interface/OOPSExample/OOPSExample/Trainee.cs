using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample
{
    /* To make Trainee child class for Coach parenet class we use Association Operator (:)*/
    //Shortcut to call and implement interface methods
    //Right Click on Interface in child class->Quick Actiona and Refractoring->Implement Interface
    public class Trainee:Coach,IAcademy,IBusinessUnit
    {
        public int TraineeId { get; set; }
        public string TraineeName { get; set; }
        public Trainee()
        {

        }
        public Trainee(int traineeId, string traineeName, int coachId, string coachName, string batchCode)
            :base(coachId,coachName,batchCode)
        {
            TraineeId = traineeId;
            TraineeName = traineeName;
        }

        //Use the below code to pass output information to Trainee class object present
        //under WriteLine() method of Program Class for output
        //Method overriding is the feature employed by OOPs to change the default implementation
        //of a method to some other implementation. Example: Here instead of converting numeric or
        //datetime datatypes to string type; ToString() will be used to pass data to Trainee object.
        //Method overloading implements static polymorhism or early binding
        //method overriding implements dynamic polymorphism or late binding
        public override string ToString()
        {
            return string.Format("\n\nTrainee Id: {0}\nTrainee Name: {1}\n{2}",
                this.TraineeId, this.TraineeName,new Coach(CoachId,CoachName,BatchCode));
        }

        public void AcademyRule()
        {
            Console.WriteLine("Stage1 completion necessary to join Cognizant Academy");
        }

        public void BusinessRule()
        {
            Console.WriteLine("Stage 2 completion necessary to join Business Unit");
        }
    }
}
