using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Zombie : Monster
    {
        //----------------------------------------------------------
        // Fields
        //----------------------------------------------------------

        protected double rateOfDecay;

        //----------------------------------------------------------
        // Parameters
        //----------------------------------------------------------

        public double RateOfDecay
        {
            get { return rateOfDecay; }
        }

        //----------------------------------------------------------
        // Constructors
        //----------------------------------------------------------

        // Parameterized constructor that takes information for this and parent class
        public Zombie(string name, int age, double constitution)
            :   base(name, age, constitution, true)
        {
            rateOfDecay = 0.93;
        }

        //----------------------------------------------------------
        // Methods
        //----------------------------------------------------------

        /// <summary>
        /// Method that simulates the passing of a day and changes constitution
        /// then checks if constitution is below 1. If it is, change animated to false
        /// </summary>
        public void DayPasses()
        {
            constitution = constitution * rateOfDecay;
            if ( constitution < 1)
            {
                currentlyAnimated = false;  
            }
        }

        /// <summary>
        /// Prints out information of Zombie using the parent class' fields
        /// </summary>
        public void PrintZombie()
        {
            Console.WriteLine("Zombie information:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Constitution: " + constitution);
            Console.WriteLine("Undead? " + undead);
            Console.WriteLine("Animated? " + currentlyAnimated);
            Console.WriteLine("Decay rate: " + rateOfDecay);

        }
    }
}
