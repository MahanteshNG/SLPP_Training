using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Coach
    {
        //any class member,properties or methods declared as prootected scope in parent class
        //can only be accessible by child class
        protected int CoachId { get; set; }
        protected string CoachName { get; set; }
        public Coach()
        {

        }

        public Coach(int coachId, string coachName)
        {
            CoachId = coachId;
            CoachName = coachName;
        }
        /*
        public void DisplayCoach()
        {
            Console.WriteLine("Coach Id: " + CoachId + "\nCoach Name: " + CoachName);
        }*/
        public override string ToString()
        {
            return string.Format("\nCoach Name: {0}\nCoach Id: {1}", CoachName, CoachId);
        }
    }
}
