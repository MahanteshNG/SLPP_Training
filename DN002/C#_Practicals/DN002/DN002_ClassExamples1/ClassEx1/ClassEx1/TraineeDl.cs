using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Classes declaration should be public
//Class, Object, Property, Methods should always be declared in Pascal Case
//The private class members or any variable should be declared in Camel Case
namespace ClassEx1
{
    //Storage class or Model Class -> Class under which you store records under class members
    //that we pass from UI class
    public class TraineeDl
    {
        //class members
        private int traineeId;
        private string traineeName;
        private double marks;
        //Parameterless or Default Constructor
        //ShortCut: Write ctor and press Tab key from keyboard twice
        public TraineeDl()
        {

        }
        //Parameterized constructor will help to pass data from UI class to this model class
        //and store the data under class members
        //ShortCut: Select the class members-> Right Click->Quick Actions and Refractoring->
        //Choose Constructor option
        public TraineeDl(int traineeId, string traineeName, double marks)
        {
            this.traineeId = traineeId;
            this.traineeName = traineeName;
            this.marks = marks;
        }

        /* Create Read-Only properties (ie properties with only get accessor) to extract data
         * from class members and pass it to UI class for display */
         //Properties are written in Pascal Case
        public int Id
        {
            get { return this.traineeId; }
        }
        public string Name
        {
            get { return this.traineeName; }
        }
        public double AverageMarks
        {
            get { return this.marks; }
        }
       

    }
}
