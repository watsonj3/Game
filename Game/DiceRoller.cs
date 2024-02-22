using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
     internal class DiceRoller
     {
          private int diceSides;
          private int diceNumber;
          private int total = 0;

          Random random = new Random();

          public void SetSides(int dSides)
          {
               this.diceSides = dSides;
          }

          public int GetSides()
          {
               return this.diceSides;
          }



     }
}
