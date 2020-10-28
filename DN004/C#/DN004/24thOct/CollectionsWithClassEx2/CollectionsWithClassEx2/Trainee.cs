using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsWithClassEx2
{
    //model class
    public class Trainee
    {
        //auto-implemented properties
        public int TraineeId { get; set; }
        public string TraineeName { get; set; }
        public string Degree { get; set; }
        public Trainee()
        {

        }
        public Trainee(int traineeId, string traineeName, string degree)
        {
            TraineeId = traineeId;
            TraineeName = traineeName;
            Degree = degree;
        }
    }
}
