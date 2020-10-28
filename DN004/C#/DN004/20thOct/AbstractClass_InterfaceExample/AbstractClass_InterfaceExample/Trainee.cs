using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceExample
{
    //ShortCut to Implement Abstract Method in Child Class
    //Right Click on Child Class-> Quick Actions and Refractoring-> Implement Abstract Class
    //ShortCut to implement interface methods
    //Right click on Interface name in child class-> Quick Actions and Refractoring -> Implement
    //Interface
    //The order of association with child class
    //child class:Abstract Class,Interface1,......,Interface_n
    public class Trainee : Coach,IBusinessUnit,IAcademy
    {
        public int TraineeId { get; set; }
        public string BatchCode { get; set; }

        public Trainee()
        {

        }

        public Trainee(int coachId, string coachName,int traineeId, string batchCode)
            :base(coachId,coachName)
        {
            TraineeId = traineeId;
            BatchCode = batchCode;
        }


        //Method Overriding implements Dynamic Polymporphism or Late Binding
        public override void TraineeAttendance()
        {
            Console.WriteLine("Daily Trainee attendance is taken by coach");
        }

        public void BusinessUnitRule()
        {
            Console.WriteLine("Stage 2 completion required to be put under projects");
        }

        public void AcademyRule()
        {
            Console.WriteLine("Stage 1 completion required to join Cognizant for CSD");
        }
    }
}
