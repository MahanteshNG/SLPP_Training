using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx2
{
    //Under Model class do the following validations:
    //Check whether the Id value is 4 digits long; otherwise throw an custom exception with a message
    //"Invalid Trainee Id..Try Again"
    public class Employee
    {
        //private members
        private int _traineeId;
        private string _traineeName;
        private double _salary;
        //Default Constructor
        public Employee()
        {

        }

        //properties
        public int Id
        {
            set {
     if (value.ToString().Length != 4)
     throw new FormatException("Invalid Id..Should be 4 digits long");
                else
                    this._traineeId = value;
                }
            get { return this._traineeId;}
        }
        public string Name
        {
            set { this._traineeName = value; }
            get { return this._traineeName; }
        }
        public double Salary
        {
            set { this._salary = value; }
            get { return this._salary; }
        }

    }

    public class SalaryValidation
    {
        public string ValidateSalaryInput(double salary)
        {
            if(salary<10000)
            {
                return "Invalid Salary";
            }
            else
            {
                return null;
            }
        }
    }
}
