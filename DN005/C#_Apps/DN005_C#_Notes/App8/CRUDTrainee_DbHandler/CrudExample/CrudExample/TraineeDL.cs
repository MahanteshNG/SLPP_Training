using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudExample
{
    //This class is the model class where data gets stored
    public class TraineeDL
    {
        public int TraineeId { get; set; }
        public string TraineeName { get; set; }
        public string BatchCode { get; set; }
        public DateTime DateOfJoining { get; set; }

        public TraineeDL()
        {

        }

        public TraineeDL(string traineeName, string batchCode, DateTime dateOfJoining)
        {            
            TraineeName = traineeName;
            BatchCode = batchCode;
            DateOfJoining = dateOfJoining;
        }
    }
}
