using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceExample
{
    //To Call or implement an abstract method in child class
    //ShortCut:Right Click on Child Class->Quick Actions and Refractoring-> Implement Abstract Class
    //ShortCut: Right click on Interface Name-> Quick Actions and Refractoring->Implement Interface
    public class Trainee:Batch,IBusinessUnit
    {
        public int TraineeId { get; set; }
        public string TraineeName { get; set; }
        public Trainee()
        {

        }
        public Trainee(string batchCode,int traineeId, string traineeName)
            :base(batchCode)
        {
            TraineeId = traineeId;
            TraineeName = traineeName;
        }

        public void TraineeInfo()
        {
            Console.WriteLine("Trainee Id: " + this.TraineeId);
            Console.WriteLine("Trainee Name: " + this.TraineeName);
        }
        public override double TraineeAnnualSalary(double monthlySalary)
        {
            return 12 * monthlySalary;
        }

        public void BusinessUnitRule()
        {
            Console.WriteLine("Stage 1 completion required to join Cognizant");
        }
    }
}
