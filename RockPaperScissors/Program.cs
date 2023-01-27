using System;
using System.Collections.Generic;
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
        public static Player Bob = new Player("Bob", 0, "Hand");
        public static Player AI = new Player("CPU", 10, "Hand");
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nSelect 'R' for Rock, 'P' for Paper,'S' for Scissors: ");
                char key = Char.ToUpper(Console.ReadKey().KeyChar);
                if (key != 'R' && key != 'S' && key != 'P' && key != '0') return;

                switch (key)
                {
                    case 'R':

                        Console.WriteLine($"\n\n{Bob.Name}<= {Bob.Choice} vs {AI.Choice} =>{AI.Name}'s " );
                        break;
                }
            }
        }
    }
}
