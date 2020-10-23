using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    public class Trainee
    {
        //private members
        private int _traineeId;
        private string _traineeName;
        private DateTime _dateOfJoining;

        //default constructor [shortcut: ctor and press Tab key twice from keybord]
        public Trainee()
        {

        }
        //parameterized
        public Trainee(int traineeId, string traineeName, DateTime dateOfJoining)
        {
            TraineeId = traineeId;
            TraineeName = traineeName;
            DateOfJoining = dateOfJoining;
        }

        public int TraineeId { get => _traineeId; set => _traineeId = value; }
        public string TraineeName { get => _traineeName; set => _traineeName = value; }
        public DateTime DateOfJoining { get => _dateOfJoining; set => _dateOfJoining = value; }

        //Method Overloading or Early Binding [many methods declared with same name but differentiated
        //buy either different args datatype or different arg numbers]
        //Method overloading implements Static Polymorphism
        public void SubjectInfo(int SubjectCount)
        {
            Console.WriteLine("Number of Subjects: " + SubjectCount);
        }
        public void SubjectInfo(string[] subjectName)
        {
            //sort array in desc manner
            Array.Sort(subjectName); //sorting will be done in asc manner
            Array.Reverse(subjectName);
            //foreach will extract data one by one from array or collection via element name
            foreach(var info in subjectName)
            {
                Console.WriteLine(info);
            }
        }
    }
}
