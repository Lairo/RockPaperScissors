using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  //TODO: Menu 
            // players
            // game
            // score, upon request listed separately somehow?
            // save/load
            // sets? 3 games in a row 10 games in a row
namespace RockPaperScissors
{
    internal class Program
    {
        public static Random random = new Random();

        public static Player Bob = new Player("Bob", 0, "Hand");
        public static Player AI = new Player("CPU", 0, "");
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(Bob.PlayerInfo);
                AI.Hand = Player.NumberToHandTranslation(random.Next(1, 4));

                Console.Write("\nSelect 'R' for Rock, 'P' for Paper,'S' for Scissors: ");
                char key = Char.ToUpper(Console.ReadKey().KeyChar);
                if (key != 'R' && key != 'S' && key != 'P' && key != '0') return;

                switch (key)
                {
                    case 'R':
                        Bob.Hand = "Rock";
                        break;
                    case 'P':
                        Bob.Hand = "Paper";
                        break;
                    case 'S':
                        Bob.Hand = "Scissors";
                        break;
                    case '0':
                        Bob.Hand = "random";
                        Player.HandToDigitConversion(Bob.Hand);
                        Bob.Hand = Player.NumberToHandTranslation(Player.HandToDigitConversion(Bob.Hand));
                        break;
                    default:
                        return;
                }

                Console.WriteLine($"\n\n {Bob.Name}'s <= {Bob.Hand} vs {AI.Hand} =>{AI.Name}'s ");
                Bob.Points += Start(Bob.Hand, AI.Hand);
            }
        }

        /// <summary>
        /// Game's point calculation function.
        /// Functions purpose is simply for visual clarity purposes.
        /// This function should NOT be used outside of this class.
        /// </summary>
        /// <param name="a">Player's Hand.</param>
        /// <param name="b">AI's Hand.</param>
        /// <returns>Points if any to be added.</returns>
        private static int Start(string a, string b )
        {            
            // Does? This needs to happen internally in Player
            int e = Player.PointCalculation(Player.ShowHandPoint(Player.HandToDigitConversion(a), Player.HandToDigitConversion(b)));
            return e;
        }
    }
}
