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
                        Console.WriteLine($"\n\n {Bob.Name}'s <= {Bob.Hand} vs {AI.Hand} =>{AI.Name}'s " );
                        string result = Player.ShowHandPoint(Player.HandToDigitConversion(Bob.Hand), Player.HandToDigitConversion(AI.Hand));

                        break;

                    case 'P':
                        Bob.Hand = "Paper";
                        Console.WriteLine($"\n\n {Bob.Name}'s <= {Bob.Hand} vs {AI.Hand} =>{AI.Name}'s ");
                        Player.HandToDigitConversion(Bob.Hand);
                        break;

                    case 'S':
                        Bob.Hand = "Scissors";
                        Console.WriteLine($"\n\n {Bob.Name}'s <= {Bob.Hand} vs {AI.Hand} =>{AI.Name}'s ");
                        Bob.Points += Player.PointCalculation(Player.ShowHandPoint(Player.HandToDigitConversion(Bob.Hand), Player.HandToDigitConversion(AI.Hand)));
 // This needs to happen internally in Player
                        break;
                    case '0':
                        Bob.Hand = "random";
                        Console.WriteLine($"\n\n {Bob.Name}'s <= {Bob.Hand} vs {AI.Hand} =>{AI.Name}'s ");                        
                        Player.HandToDigitConversion(Bob.Hand);
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
