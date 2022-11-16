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
        /// A virtual method that prints out all the information from the class
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Constitution: " + String.Format("{0:0.00}", constitution));
            Console.WriteLine("Undead? " + undead);
            Console.WriteLine("Animated? " + currentlyAnimated);
            
        }

        /// <summary>
        /// Virtual method that prints a unique way of eating a victim
        /// </summary>
        public virtual void Eat(string victimName)
        {
            Console.WriteLine($"{name} devours {victimName}.");
        }

        /// <summary>
        /// An overridden method that will return a sentence
        /// based on the stats of the monster
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (currentlyAnimated == false && undead == true)
            {
                return $"{name}'s constitution has fallen to zero. " +
                    $"They are no longer animated and cannot be revived.";
            }
            else if (currentlyAnimated == false && undead == false)
            {
                return $"{name}'s constitution has fallen to zero. " +
                    $"They are no longer animated but can be resuscitated.";
            }
            else if (currentlyAnimated == true && age >= 60)
            {
                return $"{name} is old at the ripe age of {age}." +
                    $" They are existing with {constitution} constitution.";
            }
            else 
            {
                return $"{name} is young at {age} years old." +
                    $" They are existing with {constitution} constitution.";
            }
            
        }
    }
}
