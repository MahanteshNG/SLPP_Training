using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsWithClassEx2
{
    //operational class
    public class Utility
    {
        //Create a method of return type and pass the list of trainees to program class for output
        public static List<Trainee> DisplayAllTrainees(List<Trainee> list)
        {
            return list;
        }

        //Create a method of return type and pass the list of trainees to Program class for output
        //for trainees who are haing the degree that is searched
        public static List<Trainee> DisplayAllTrainees(List<Trainee> list,string searchDegree)
        {
            return list.Where(x => x.Degree.Equals(searchDegree,
                StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        //Create a method of return type which will return a Trainee Object to Program class
        //to display the trainee against searched Id
        public static Trainee DisplayTraineeById(List<Trainee> list,int searchedId)
        {
            return list.Where(x => x.TraineeId == searchedId).FirstOrDefault();
            //As dafault value of any object is null; so if TraineeId does not match searchedId
            //a null value will be returned. If matches; that particular Trainee info will be extracted
            //and sent for display
        }
    }
}
