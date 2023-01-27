using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors 
{
    internal class Player
    {
        public string Name { get; private set; }
        public int Points { get; private set; }
        public string Choice { get; set; }



        public Player(string name, int points, string choice)
        {
            Name = name;
            Points = points;
            Choice = choice;
         }
        public string PlayerInfo
        {
            get { return $"Player {Name} has {Points} points."; }
        }

    }
}
