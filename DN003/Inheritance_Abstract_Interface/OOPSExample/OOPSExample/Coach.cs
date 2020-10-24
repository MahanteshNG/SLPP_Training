using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample
{
    //Shortcut to call and implement Abstract class Abstract Method under Child class
    //Right Click on Child Class-> Quick Action and Refrectoring-> Implement Abstract Class
    public class Coach:Batch
    {
        public int CoachId { get; set; }
        public string CoachName { get; set; }
        public Coach()
        {

        }
        public Coach(int coachId, string coachName, string batchCode):base(batchCode)
        {
            CoachId = coachId;
            CoachName = coachName;
        }
        public override string ToString()
        {
            return string.Format("Coach Id: {0}\nCoach Name: {1}",
                this.CoachId, this.CoachName);
        }

        public override double CoachSalary(double monthlySalary)
        {
            return 12 * monthlySalary;
        }
    }
}
