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
        
        /// <summary>
        /// Generates a random number between 1-6 (inclusive)
        /// </summary>
        /// <returns></returns>
        public int RollDie()
        { 
            randomNum = new Random();
            return randomNum.Next(1, 7); 
        }

        /// <summary>
        /// Generates the sum of how many dice are rolled
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int RollDice(int amount)
        {
            int sum = 0;

           for (int i = 0; i < amount; i++)
            {
                sum += RollDie();
            }

            return sum;
        }

    }//End of internal class
}
