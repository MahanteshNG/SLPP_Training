using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{

    /* Inheritance in C# is done by Association Operator (:)
     * Here Batch is parent class; Trainee is child class */
<<<<<<< HEAD
     /* ShortCut to implement Interface Methods under Child Class
      * Right Click on Interface->Quick Actions and Refrectoring->Implement Interface*/
    public class Trainee:Batch,IAcademy,IBusinessUnit
=======
    public class Trainee:Batch
>>>>>>> 92e668f7065a9cd8b058142a609e80a70193b812
    {
        public string TraineeId { get; set; }
        public string TraineeName { get; set; }
        public Trainee()
        {

        }
        public Trainee(string companyName,string batchId, int traineeCount, string traineeId, string traineeName)
            : base(companyName,batchId, traineeCount)
        {
            TraineeId = traineeId;
            TraineeName = traineeName;
        }

        //to output data to Program class via class object write below codes:
        //By default ToString() is used to convert numeric or datetime datatype to string type
        //But here we need ToString() to send data to class object present under WriteLine() method
        //Method Overriding changes the default implemetation of a method to be used for 
        //different implemenation. 
        //Method Overloading implements Static Polymorphism or Early Binding
        //Method Overriding implements Dynamic Polymorphism or Late Binding
        public override string ToString()
        {
            return string.Format("Trainee Id: {0}\nTrainee Name: {1}\n{2}",
                this.TraineeId, this.TraineeName,new Batch(CompanyName,BatchId,TraineeCount));
        }

<<<<<<< HEAD
        public void AcademyRule()
        {
            Console.WriteLine("Stage 1 Knockout clearance required to join Cognizant Academy");
        }

        public void BusinessUnitRule()
        {
            Console.WriteLine("Stage 2 Clearance Required to Join Projects");
        }
=======
>>>>>>> 92e668f7065a9cd8b058142a609e80a70193b812
    }
} 

