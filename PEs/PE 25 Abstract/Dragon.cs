using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_25_Abstract
{
    /// <summary>
    /// Dragon child class of the Monster base class that inherits all 
    /// fields, properties, and methods. Has a resistance type to certain attacks.
    /// </summary>
    internal class Dragon : Monster
    {
        //-------------------------------------------------
        // Fields
        //-------------------------------------------------

        private string resistanceType;

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
        /// <param name="resistanceType"> takes a string </param>
        public Dragon (string name, int health, string attackType, string resistanceType) 
            : base (name, health, attackType)
        {
            this.resistanceType = resistanceType;
        }

        //-------------------------------------------------
        // Methods
        //-------------------------------------------------

        /// <summary>
        /// Calculates damage done to monster by calling the TakeDamage method
        /// after the random number is generated between 10-20
        /// </summary>
        /// <param name="monster"> takes an instance of the monster or child classes </param>
        public override void Attack(Monster monster)
        {
            int damage = randomGenerator.Next(10,21);
            Console.Write($"{name} attacks for {damage}. ");
            monster.TakeDamage(damage, attackType);

            
        }

        /// <summary>
        /// Checks the attack type against the Dragon's resistance type
        /// </summary>
        /// <param name="damage"> takes an int </param>
        /// <param name="attackType"> takes a string </param>
        public override void TakeDamage(int damage, string attackType)
        {
            if (attackType == resistanceType)
            {
                Console.WriteLine($"{name} takes {damage} {attackType} " +
                    $"damage, halved to {damage/2} due to a {resistanceType} resistance");
                damage = damage / 2;
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
            return $"The Dragon " + base.ToString() + $" {name} is resistant to {resistanceType} damage.";
        }
    }
}
