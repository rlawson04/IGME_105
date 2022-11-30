using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_Character_Battle
{
    /// <summary>
    /// The Archer child classs which inherits from the CommonCharacter class 
    /// in addition to having arrows and dexterity which they use to attack
    /// and dodge attacks respectively.
    /// </summary>
    internal class Archer : CommonCharacter
    {
        // --------------------------------------------------------------------
        // Fields
        // --------------------------------------------------------------------

        private int arrowsLeft;
        private int dexterity;
        private double dodgeChance;
        

        // --------------------------------------------------------------------
        // Properties
        // --------------------------------------------------------------------

        // Read only property that returns arrows left
        public int ArrowsLeft
        {
            get { return arrowsLeft; }
        }

        // Read only property that returns dexterity
        public int Dexterity
        {
            get { return dexterity; }
        }

        // Read only property that returns dodgechance 
        public double DodgeChance
        {
            get { return dodgeChance; }
        }

        // --------------------------------------------------------------------
        // Constructors
        // --------------------------------------------------------------------
       
        /// <summary>
        /// Parameterized Archer constructor
        /// </summary>
        /// <param name="name"> takes in a string </param>
        /// <param name="health"> takes in an int </param>
        /// <param name="level"> takes in an int </param>
        /// <param name="isDead"> takes in a bool </param>
        /// <param name="random"> takes in a random object </param>
        public Archer(string name, int health, int level, bool isDead, Random random)
            : base(name, health, level, isDead, random)
        {
            arrowsLeft = 10;
            dodgeChance = health/2;
            dexterity = random.Next(4, 11) + level;
        }

        // --------------------------------------------------------------------
        // Methods
        // --------------------------------------------------------------------

        /// <summary>
        /// Asks if the character is ready to flee based on their health value
        /// </summary>
        /// <returns> returns true if their health is below 5 points
        /// or they have no arrows, false otherwise </returns>
        public override bool ReadyToFlee()
        {
            if (health <= 5 || arrowsLeft == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Attacks using bow and arrow and then takes away an arrow
        /// </summary>
        /// <returns> the damage of the attack </returns>
        public override int Attack()
        {
            int attack = random.Next(1, 7) + dexterity + (health/random.Next(5, 11));
            arrowsLeft -= 1;
            return attack;
        }

        /// <summary>
        /// Takes damage or dodges taking half damage instead
        /// </summary>
        /// <param name="amount"> takes an int </param>
        public override void TakeDamage(int amount)
        {
            if (random.Next(1, health) >= dodgeChance)
            {
                health -= amount / 2;
            }
            else
            {
                health -= amount;
            }
        }

        /// <summary>
        /// Prints the specific information about the Archer
        /// </summary>
        /// <returns> A string with the archer's information </returns>
        public override string ToString()
        {
            return base.ToString() + $" They are an Archer with {arrowsLeft} arrows" +
                $" left to shoot. Their arrows deal extra damage based on their dexterity," +
                $" and randomly with the more health they have. They have the chance to half " +
                $"incoming damage using their dodge chance stat which is currently {dodgeChance}";
        }
    }
}
