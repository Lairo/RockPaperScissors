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
                //Player Info??
                Console.WriteLine(Bob.PlayerInfo);


                AI.Hand = Player.AiHand(random.Next(1, 4));

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
                        Bob.Hand = Player.AiHand(Player.HandToDigitConversion(Bob.Hand));
                        break;
                    default:
                        return;
                }

                Console.WriteLine($"\n\n {Bob.Name}'s <= {Bob.Hand} vs {AI.Hand} =>{AI.Name}'s ");
                Bob.Points += start(Bob.Points, Bob.Hand, AI.Hand);
            }
        }

        public static int start(int a, string b, string c )
        {            
            // Does? This needs to happen internally in Player
            int e = Player.PointCalculation(Player.ShowHandPoint(Player.HandToDigitConversion(b), Player.HandToDigitConversion(c)));
            return e;
        }
    }
}
