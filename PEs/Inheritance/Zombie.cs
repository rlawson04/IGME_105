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
        // Properties
        //----------------------------------------------------------

        // Read-only property that returns rateOfDecay
        public double RateOfDecay
        {
            get { return rateOfDecay; }
        }

        //----------------------------------------------------------
        // Constructors
        //----------------------------------------------------------

        /// <summary>
        /// Parameterized constructor that takes information for this and parent class
        /// </summary>
        /// <param name="name"> takes in a string </param>
        /// <param name="age"> takes in an int </param>
        /// <param name="constitution"> takes in a double </param>
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
        /// Prints out information of Zombie using the parent class' print method
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("Zombie information: ");
            base.Print();
            Console.WriteLine("Decay rate: " + rateOfDecay);
        }

        /// <summary>
        /// Overridden method that prints a unique way of eating a victim
        /// </summary>
        /// <param name="victimName"> takes in a string </param>
        public override void Eat(string victimName)
        {
            Console.WriteLine($"{name} chomps on the brains of {victimName}" +
                $" but is still hungry...");
        }

        /// <summary>
        /// An overriden method that returns strings based on the zombies stats 
        /// </summary>
        /// <returns> a string depending on the stats of the zombie </returns>
        public override string ToString()
        {
            
            if (currentlyAnimated == true)
            {
                return base.ToString() +
                    $" The zombie {name} still has time left in the game";
            }
            if (currentlyAnimated == false)
            {
                return base.ToString() +
                    $" As a zombie, {name} lost the ability to play in this game";
            }
            return ToString();
        }
    }
}
