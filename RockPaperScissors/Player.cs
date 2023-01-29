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

        public string name;
        public string Name
        { 
            get { return name; }
            set { name = value;}
        }

        private int points;
        public int Points
        { 
            get { return points; }
            set { points = value; }
        }       

        private string hand;

        public string Hand
        {
            get { return hand; }
            set { hand = value; }
        }
        
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

        //rock     1 
        //paper    2
        //scissors 3
        public static string ShowHandPoint(int convertedDigit, int AIDigit)
        {
            if (convertedDigit == AIDigit) return "Tie";
            else if (convertedDigit == 1 && AIDigit == 2) return "AI Wins"; // points?
            else if (convertedDigit == 2 && AIDigit == 3) return "AI Wins"; // points?
            else if (convertedDigit == 3 && AIDigit == 1) return "AI Wins"; // points?
            else
            {
                Console.WriteLine($"You won +1.");
                return "Bob Wins";
            }
        }

        public static int PointCalculation(string result)
        {
            if (result == "Bob Wins") return 1;

            if (result == "AI Wins") return 0;
            return 0;
        }
    }
}
