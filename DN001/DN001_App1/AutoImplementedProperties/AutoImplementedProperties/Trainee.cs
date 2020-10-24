using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementedProperties
{
    public class Trainee
    {
        //Auto Implemented Properties
        public string TraineeId { get; set; }
        public string TraineeName { get; set; }
        public Trainee()
        {

        }

        public Trainee(string traineeId, string traineeName)
        {
            TraineeId = traineeId;
            TraineeName = traineeName;
        }
        //Feature through which we can change method implemetation of parent class under child class
        //Method Overriding implements Dynamic Polymorphism or Late Binding
        public override string ToString()
        {
            return string.Format("Trainee Id: " + TraineeId + "\nTrainee Name: " + TraineeName);
        }
    }
}
