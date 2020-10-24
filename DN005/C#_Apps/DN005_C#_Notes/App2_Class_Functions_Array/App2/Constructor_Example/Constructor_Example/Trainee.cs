using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Example
{
    public class Trainee
    {
        //class members
        private int _id;
        private string _name;
        //properties
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        //parameterless or default constructor
        public Trainee()
        {

        }
        //parameterized constructor
        public Trainee(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString()
        {
            return string.Format("Trainee Id: {0}\nTrainee Name:{1}",
                this.Id, this.Name);
        }
    }
}
