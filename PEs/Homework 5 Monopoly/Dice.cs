using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_Monopoly
{
    internal class Dice
    {
        //Fields
        private Random randomNum;

        //Constructors
        

        //Methods
        public int RollDie()
        { 
            randomNum = new Random();
            return randomNum.Next(1, 7); 
        }

        public int RollDice(int amount)
        {
            // Add the RollDie method twice to simulate two dice being rolled
            amount = RollDie();
            amount += RollDie();

            return amount;
        }

    }//End of internal class
}
