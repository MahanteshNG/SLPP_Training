using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject_Demo1
{
    //model class where we can store data under class members which we send to this class
    //from UI(ie void main class)
    //class name should be written in Pascal case
    public class TraineeModel
    {
        //Abstraction concept of OOPs data members should be hidden
        //Private Access Scope
        //Class members have to be written in camel case
        private int _id;
        private string _traineeName;
        private DateTime _dateofJoining;

        //Create a default or parameterless constructor
        //shortcut: Write ctor and press Tab key from keyboard twice
        public TraineeModel()
        {

        }
        //To create parameterized constructor without writting any code
        //Select the class members-> Right Click-> Quick Actions and Refractoring-> Select Constructor option
        public TraineeModel(int id, string traineeName, DateTime dateofJoining)
        {
            Id = id;
            TraineeName = traineeName;
            DateofJoining = dateofJoining;
        }

        // To create Properties from class members without writting code
        //Select class members->Right Click->Quick Actions and Refractoring->Select Property Option
        public int Id { get => _id; set => _id = value; }
        public string TraineeName { get => _traineeName; set => _traineeName = value; }
        public DateTime DateofJoining { get => _dateofJoining; set => _dateofJoining = value; }

        

    }
}
