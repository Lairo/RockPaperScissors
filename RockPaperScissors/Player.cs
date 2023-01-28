using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors 
{
    internal class Player
    {
        public static Random randomer = new Random();
        public string Name { get; private set; }
        public int Points { get; private set; }
        public string Hand { get; set; }
        
        public Player(string name, int points, string hand)
        {
            Name = name;
            Points = points;
            Hand = hand;
         }
        public string PlayerInfo
        {
            get { return $"Player {Name} has {Points} points."; }
        }
        
            
            
        public static int HandToDigitConversion(string Hand)
        {
            int guido = randomer.Next(1, 4);

            if (Hand == "Rock") return 1;
            else if (Hand == "Paper") return 2;
            else if (Hand == "Scissors") return 3;
            else return guido;
        }

        public static string AiHand(int aiHand)
        {
            if (aiHand == 1 ) return "Rock";
            if (aiHand == 2) return "Paper";
            if (aiHand == 3) return "Scissors";
            return null;
        }
    }
}
