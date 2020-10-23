using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    /* The inheritance is done by : [association operator]. Here Player is child class;
     * Team is parent class */
    public class Player:Team
    {
        public string PlayerName { get; set; }
        public string Skill { get; set; }
        public Player()
        {

        }
        public Player(string playerName,string skill,
            string teamName, int playerCount) :base(teamName,playerCount)
        {
            PlayerName = playerName;
            Skill = skill;
        }
        //Method Overriding is a process to change the default inplementation of a method
        //present under parent class to other implementation in child class.
        //example: ToString() Default Implementation is convert numeric or DateTime Datatype
        //to String type. But Here we will use ToString() to pass output info to class object
        //present under WriteLine()
        //Method Overriding implements Dynamic Polymorphism or Late Binding
        public override string ToString()
        {
            return string.Format("{0}\nPlayer Name: {1}\nSkill: {2}", 
                new Team(TeamName,PlayerCount), this.PlayerName, this.Skill);
        }
    }
}
