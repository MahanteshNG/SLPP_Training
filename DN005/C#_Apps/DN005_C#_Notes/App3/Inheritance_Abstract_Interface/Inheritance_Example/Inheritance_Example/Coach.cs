using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    public abstract class Coach
    {
        //class members
        private int _coachId;
        private string _coachName;
        //properties
        public int CoachId { get => _coachId; set => _coachId = value; }
        public string CoachName { get => _coachName; set => _coachName = value; }
        public Coach()
        {

        }
        public Coach(int coachId, string coachName)
        {
            _coachId = coachId;
            _coachName = coachName;
        }

        /*public override string ToString()
        {
            return string.Format("Coach Id: {0}\nCoach Name: {1}",
                this.CoachId, this.CoachName);
        }*/

        public void DisplayCoach()
        {
            Console.WriteLine("Coach Id: {0}\nCoach Name: {1}",
                this.CoachId, this.CoachName);
        }

        public abstract bool TraineeResult(float[] marks, int size);
    }
}
