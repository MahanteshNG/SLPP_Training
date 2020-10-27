using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("Enter Team Name: ");

            string teamName = Console.ReadLine();
            Console.WriteLine("Enter Player Count: ");
            int playerCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Player Name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Enter Player Skill:");
            string skill = Console.ReadLine();
            //Pass data to Player Parameterized Constructor
            player = new Player(playerName, skill, teamName, playerCount);
            /*
            Console.WriteLine("\nTeam Name: {0}\nPlayer Count: {1}\nPlayer Name: {2}\nSkill: {3}",
                player.TeamName, player.PlayerCount, player.PlayerName, player.Skill);
            */
            Console.WriteLine(player);

        }
    }
}
