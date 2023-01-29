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

        /// <summary>
        /// Contains the Player's Name.
        /// </summary>
        public string Name
        { 
            get { return name; }
            set { name = value;}
        }
        
        private int points;

        /// <summary>
        /// Contains the Player's points
        /// </summary>
        public int Points
        { 
            get { return points; }
            set { points = value; }
        }       


        private string hand;

        /// <summary>
        /// Contains Players hand
        /// rock     1 
        /// paper    2
        /// scissors 3
        /// </summary>
        public string Hand
        {
            get { return hand; }
            set { hand = value; }
        }

        /// <summary>
        /// The Player Constructor.
        /// </summary>
        /// <param name="name">Player's name.</param>
        /// <param name="points">Player's points.</param>
        /// <param name="hand">Player's hand</param>
        public Player(string name, int points, string hand)
        {
            Name = name;
            Points = points;
            Hand = hand;
         }

        /// <summary>
        /// Prints player information to the screen.
        /// </summary>
        public string PlayerInfo
        {
            get { return $"Player {Name} has {Points} points."; }
        }
        
        /// <summary>
        /// Converts player's hand text to digital 1-3, for game calculation.
        /// If the hand is random, uses Random function to set give a 
        /// random hand to the player.
        /// </summary>
        /// <param name="Hand">Player's current hand to be converted to 1-3.</param>
        /// <returns></returns>
        public static int HandToDigitConversion(string Hand)
        {
            int guido = randomer.Next(1, 4);


            if (Hand == "Rock") return 1;
            else if (Hand == "Paper") return 2;
            else if (Hand == "Scissors") return 3;
            else return guido;
        }

        /// <summary>
        /// Converts player's digital hand to text Rock, paper or scissors
        /// For game's visual clarity.
        /// </summary>
        /// <param name="DigitalHand">Player's current digital hand converted to Rock, Paper or Scissors.</param>
        /// <returns></returns>
        public static string NumberToHandTranslation(int DigitalHand)
        {
            if (DigitalHand == 1 ) return "Rock";
            if (DigitalHand == 2) return "Paper";
            if (DigitalHand == 3) return "Scissors";
            return null;
        }

        /// <summary>
        /// Game's calculator.
        /// </summary>
        /// <param name="convertedDigit">Player's Converted hand to digital.</param>
        /// <param name="AIDigit">AI's Digital Hand.</param>
        /// <returns>The text for the winner. </returns>
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
