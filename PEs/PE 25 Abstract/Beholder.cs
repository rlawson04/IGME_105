using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_25_Abstract
{
    /// <summary>
    /// Beholder child class of the Monster base class that inherits all 
    /// fields, properties, and methods. Has a vulnerability type to certain attacks.
    /// </summary>
    internal class Beholder : Monster
    {
        //-------------------------------------------------
        // Fields
        //-------------------------------------------------

        private string vulnerabilityType;

        //-------------------------------------------------
        // Properties
        //-------------------------------------------------

        // Inherited

        //-------------------------------------------------
        // Constructors
        //-------------------------------------------------

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="name"> takes a string </param>
        /// <param name="health"> takes an int </param>
        /// <param name="attackType"> takes a string </param>
        /// <param name="vulnerabilityType"> takes a string </param>
        public Beholder(string name, int health, string attackType, string vulnerabilityType)
            : base(name, health, attackType)
        {
            this.vulnerabilityType = vulnerabilityType;
        }

        //------------------------------------------------
        // Methods
        //------------------------------------------------

        /// <summary>
        /// Calls a random number between 5 and 25,
        /// and then calls the take damage method on the chosen monster
        /// </summary>
        /// <param name="monster"> takes an instance of the monster or child classes </param>
        public override void Attack(Monster monster)
        {
            int damage = randomGenerator.Next(5,26);
            Console.Write($"{name} attacks for {damage}. ");
            monster.TakeDamage(damage, attackType);
        }

        /// <summary>
        /// Checks the attack type against the Beholder's vulnerability type 
        /// </summary>
        /// <param name="damage"> takes an int </param>
        /// <param name="attackType"> takes a string </param>
        public override void TakeDamage(int damage, string attackType)
        {
            if (attackType == vulnerabilityType)
            {
                Console.WriteLine($"{name} takes {damage} {attackType} " +
                    $"damage, doubled to {damage * 2} due to a {vulnerabilityType} vulnerability");
                damage = damage * 2;
                health -= damage;
            }
            else
            {
                Console.WriteLine($"{name} takes {damage} damage.");
                health -= damage;
            }
        }

        /// <summary>
        /// Overrides ToString method and adds more information to the parent class's method
        /// </summary>
        /// <returns> The parent class's string plus more specific information </returns>
        public override string ToString()
        {
            return $"The Beholder " + base.ToString() + $" {name} is vulerable to {vulnerabilityType} damage.";
        }
    }
}
