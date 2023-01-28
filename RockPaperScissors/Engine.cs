using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Engine
    { //rock     1 
      //paper    2
      //scissors 3
        public static string ShowHandPoint(int convertedDigit, int AIDigit )
        {
            if (convertedDigit == AIDigit) return "Tie";
            else if (convertedDigit == 1 && AIDigit == 2) return "AI Wins"; // points?
            else if (convertedDigit == 2 && AIDigit == 3) return "AI Wins"; // points?
            else if (convertedDigit == 3 && AIDigit == 1) return "AI Wins"; // points?
            else
            return "Bob Wins";
        }

    }
}
