using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Monster
    {
        //---------------------------------------------------
        // Fields
        //---------------------------------------------------

        protected string name;
        protected int age;
        protected double constitution;
        protected bool undead;
        protected bool currentlyAnimated;

        //---------------------------------------------------
        // Properties
        //---------------------------------------------------

        // Public property to return name
        public string Name
        {
            get { return name; }
        }

        // public property to return constitution
        public double Constitution
        {
            get { return constitution; }
        }

        // Public property to get and set the bool Currently Animated
        public bool CurrentlyAnimated
        {
            get { return currentlyAnimated; }
            set { currentlyAnimated = value; }
        }

        //---------------------------------------------------
        // Constructors
        //---------------------------------------------------

        // Default constructor for monster
        public Monster()
        {
            name = "unknown";
            age = 0;
            constitution = 0;
            undead = false;
            currentlyAnimated = false;

        }

        // Parameterized constructor that takes name, age, constitution, and undead
        public Monster(string name, int age, double constitution, bool undead)
        {
            this.name = name;
            this.age = age;
            this.constitution = constitution;
            this.undead = undead;
            if (constitution > 0)
            {
                currentlyAnimated = true;
            }
            else
            {
                currentlyAnimated = false;
            }
        }

        //---------------------------------------------------
        // Methods
        //---------------------------------------------------

        /// <summary>
        /// Method that prints out all the information from the class
        /// </summary>
        public void PrintMonster()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Constitution: " + constitution);
            Console.WriteLine("Undead? " + undead);
            Console.WriteLine("Animated? " + currentlyAnimated);
            
        }
    }
}
