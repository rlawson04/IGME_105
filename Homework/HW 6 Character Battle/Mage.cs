using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_Character_Battle
{
    /// <summary>
    /// The Mage child classs which inherits from the 
    /// CommonCharacter class in addition to having mp 
    /// and armor to cast spells and block damage respectively.
    /// </summary>
    internal class Mage : CommonCharacter
    {
        // --------------------------------------------------------------------
        // Fields
        // --------------------------------------------------------------------

        private int mp;
        private int armor;

        // --------------------------------------------------------------------
        // Properties
        // --------------------------------------------------------------------

        // Read only property that returns mp
        public int Mp
        {
            get { return mp; }
        }

        // Read only property that returns armor 
        public int Armor
        {
            get { return armor; }
        }

        // --------------------------------------------------------------------
        // Constructors
        // --------------------------------------------------------------------

        /// <summary>
        /// Parameterized Mage constructor
        /// </summary>
        /// <param name="name"> takes in a string </param>
        /// <param name="health"> takes in an int </param>
        /// <param name="level"> takes in an int </param>
        /// <param name="isDead"> takes in a bool </param>
        /// <param name="random"> takes in a random object </param>
        public Mage(string name, int health, int level, bool isDead, Random random)
            : base(name, health, level, isDead, random)
        {
            mp = 100;
            armor = 5;
        }

        // --------------------------------------------------------------------
        // Methods
        // --------------------------------------------------------------------

        /// <summary>
        /// Asks if the character is ready to flee based on their health value
        /// </summary>
        /// <returns> returns true if their health is below one fourth
        /// or if they are out of mp, false otherwise </returns>
        public override bool ReadyToFlee()
        {
            if (health == health / 4 || mp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Attacks using magic and then takes away some mp
        /// </summary>
        /// <returns> the damage of the attack </returns>
        public override int Attack()
        {
            int attack = random.Next(1, 11) + level + mp/10;
            mp -= random.Next(10, 21);
            return attack;
        }

        /// <summary>
        /// Takes damage after subtracting armor value
        /// </summary>
        /// <param name="amount"> takes an int </param>
        public override void TakeDamage(int amount)
        {
            amount = amount - armor;
            health -= amount;
        }

        /// <summary>
        /// Prints the specific information about the Mage
        /// </summary>
        /// <returns> A string with the mage's information </returns>
        public override string ToString()
        {
            return base.ToString() + $" They are a Mage with {mp}" +
                $" mp left to cast sorceries which do more damage the" +
                $" higher the mp they have, and the higher level they are. " +
                $"They also wear armor which reduces 5 incoming damage.";
        }
    }
}
