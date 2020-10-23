using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeClassEx
{
    public class TraineeDl
    {
        //Auto Implemented Properties
        public int TraineeId { get; set; }
        public string TraineeName { get; set; }
        public DateTime Dob { get; set; }
        public TraineeDl()
        {

        }
        public TraineeDl(int traineeId, string traineeName, DateTime dob)
        {
            TraineeId = traineeId;
            TraineeName = traineeName;
            Dob = dob;
        }
        //Override ToString() is used if the output is done only via class object call
        //under WriteLine() Method
        public override string ToString()
        {
            return string.Format("Trainee Name: " + this.TraineeName + "\nTrainee Id: " + this.TraineeId +
                "\nDate Of Birth: " + this.Dob);
        }
    }
}
