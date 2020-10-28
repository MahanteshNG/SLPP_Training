using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Create a class called Trainee with members id,name,marks. Use proper getter and setters. 
 *If the Marks is -ve then throw a Custom Exception with a message "Invalid Marks". 
 * Do exception check under model class */ 
 
    /* To Handle Exceptions we use Try-Catch block. Try will contain code that can cause exception;
     * catch block will give message for exception */

namespace AutoImplemetedProperties_Example1
{
   public class Trainee
    {
        //members
        private int _id;
        private string _name;
        private double _marks;

        //properties
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        public double Marks
        {
           set
            {
                if (value < 0)
                    throw new Exception("Invalid Marks");
                else
                    _marks = value;
            }
            get
            {
                return _marks;
            }
        }
    }
}
