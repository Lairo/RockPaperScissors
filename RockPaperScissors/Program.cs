using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  //TODO: Menu 
            // players
            // game
            // score
            // save/load
            // sets? 3 games in a row 10 games in a row
namespace RockPaperScissors
{
    internal class Program
    {
        public static Random random = new Random();
        public static Player Bob = new Player("Bob", 0, "Hand");
        public static Player AI = new Player("CPU", 10, "");
        static void Main(string[] args)
        {
            while (true)
            {
                AI.Hand = Player.AiHand(random.Next(1, 4));

                Console.Write("\nSelect 'R' for Rock, 'P' for Paper,'S' for Scissors: ");
                char key = Char.ToUpper(Console.ReadKey().KeyChar);
                if (key != 'R' && key != 'S' && key != 'P' && key != '0') return;

                switch (key)
                {
                    case 'R':
                        Bob.Hand = "Rock";
                        Console.WriteLine($"\n\n {Bob.Name}'s <= {Bob.Hand} vs {AI.Hand} =>{AI.Name}'s " );
                        Engine.ShowHandPoint(Player.HandToDigitConversion(Bob.Hand), Player.HandToDigitConversion(AI.Hand));
                        break;

                    case 'P':
                        Bob.Hand = "Paper";
                        Console.WriteLine($"\n\n {Bob.Name}'s <= {Bob.Hand} vs {AI.Hand} =>{AI.Name}'s ");
                        Player.HandToDigitConversion(Bob.Hand);
                        break;

                    case 'S':
                        Bob.Hand = "Scissors";
                        Console.WriteLine($"\n\n {Bob.Name}'s <= {Bob.Hand} vs {AI.Hand} =>{AI.Name}'s ");
                        Player.HandToDigitConversion(Bob.Hand);
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
