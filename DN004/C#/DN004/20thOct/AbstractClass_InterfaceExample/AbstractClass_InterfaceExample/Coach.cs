using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceExample
{
    public abstract class Coach
    {
        public int CoachId { get; set; }
        public string CoachName { get; set; }

        public Coach()
        {

        }

        protected Coach(int coachId, string coachName)
        {
            CoachId = coachId;
            CoachName = coachName;
        }

        public abstract void TraineeAttendance();
    }
}
