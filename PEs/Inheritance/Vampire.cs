using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Vampire : Monster
    {
        //----------------------------------------------------------
        // Fields
        //----------------------------------------------------------

        protected double rateOfHunger;
        protected string form;

        //----------------------------------------------------------
        // Properties
        //----------------------------------------------------------

        // Read-only property that returns rateOfHunger
        public double RateOfHunger
        {
            get { return rateOfHunger; }
        }

        // Read-only property that returns form
        public string Form
        {
            get { return form; }
        }

        //----------------------------------------------------------
        // Constructors
        //----------------------------------------------------------


        public Vampire(string name, int age, double constitution)
            : base(name, age, constitution, false)
        {
            rateOfHunger = constitution * 0.08;
            form = "human";
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
            constitution = constitution - rateOfHunger;
            if (constitution <= 60)
            {
                rateOfHunger = rateOfHunger + 2;
            }
            if (constitution < 1)
            {
                currentlyAnimated = false;
            }
        }

        /// <summary>
        /// Prints out information of Vampire using the parent class' fields
        /// </summary>
        public void PrintVampire()
        {
            Console.WriteLine("Vampire information:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Constitution: " + constitution);
            Console.WriteLine("Undead? " + undead);
            Console.WriteLine("Animated? " + currentlyAnimated);
            Console.WriteLine("Decay rate: " + rateOfHunger);
            Console.WriteLine($"Currently in {form} form");

        }
    }
}
