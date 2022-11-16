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
        /// Prints out information of Vampire using the parent class' print method
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("Vampire information: ");
            base.Print();
            Console.WriteLine("Hunger rate: " + rateOfHunger);
            Console.WriteLine($"Currently in {form} form");
        }

        /// <summary>
        /// Overridden method that prints a unique way of eating a victim
        /// </summary>
        /// <param name="victimName"></param>
        public override void Eat(string victimName)
        {
            Console.WriteLine($"{name} drinks the blood of {victimName}" +
                $" and feels restored.");
        }

        /// <summary>
        /// Changes the vampires form to human or bat 
        /// unless their constitution is too low
        /// </summary>
        public void Shapeshift()
        {
            if (constitution >= 10)
            {
                if (form == "human")
                {
                    form = "bat";
                    Console.WriteLine($"{name} shifts into {form} form.");
                }
                else if (form == "bat")
                {
                    form = "human";
                    Console.WriteLine($"{name} shifts into {form} form.");
                }
            }
            if (constitution < 10)
            {
                Console.WriteLine(name +
                    " no longer has the energy to swap forms");
            }
        }

        /// <summary>
        /// An overriden method that returns strings based on the vampires stats 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (constitution > 60)
            {
                return base.ToString() +
                    $" {name}'s hunger is in check as they explore the night in " +
                    $"{form} form";
            }
            if (constitution <= 60 && constitution >= 1)
            {
                return base.ToString() +
                    $" {name} desperately wanders the night as a {form} in search" +
                    $" of a midnight snack to curb hunger.";
            }
            else
            {
                return base.ToString() +
                    $" {name}, lifeless from hunger, waits for a companion to bring " +
                    $"a fresh treat before playing again.";
            }

        }
    }
}
