using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Team
    {
        //Auto Implemented Properties
        public string TeamName { get; set; }
        public int PlayerCount { get; set; }
        public Team()
        {

        }
        public Team(string teamName, int playerCount)
        {
            TeamName = teamName;
            PlayerCount = playerCount;
        }

        public override string ToString()
        {
            return string.Format("Team Name: {0}\nPlayer Count: {1}",
                this.TeamName, this.PlayerCount);
        }
    }
}
