using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HW_6_Character_Battle
{
    internal class CommonCharacter
    {
        // --------------------------------------------------------------------
        // Fields
        // --------------------------------------------------------------------

        protected string name = " ";
        protected int health;
        protected int level;
        protected bool isDead;
        protected Random random = new Random();

        // --------------------------------------------------------------------
        // Properties
        // --------------------------------------------------------------------

        // Read only property that returns the name as a string
        public string Name
        {
            get { return name; }
        }

        // Read only property that returns the health as an int
        public int Health
        {
            get { return health; }
        }

        // A read and write property that returns level or changes its value
        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        // Read only property that returns if they are alive as a bool
        public bool IsDead
        {
            get { return isDead; }
        }

        // --------------------------------------------------------------------
        // Constructors
        // --------------------------------------------------------------------

        /// <summary>
        /// Parameterized constructor for the common character
        /// </summary>
        /// <param name="name"> takes in a string </param>
        /// <param name="health"> takes in an int </param>
        /// <param name="level"> takes in an int </param>
        /// <param name="isDead"> takes in a bool </param>
        /// <param name="random"> takes in a random object </param>
        public CommonCharacter(string name, int health, int level, bool isDead, Random random)
        {
            this.name = name;
            this.health = health;
            this.level = level;
            this.isDead = isDead;
            this.random = random;
        }

        // --------------------------------------------------------------------
        // Methods
        // --------------------------------------------------------------------

        /// <summary>
        /// Virtual method to use a basic attack
        /// </summary>
        /// <returns> their level multiplied by 5 </returns>
        public virtual int Attack()
        {
            int damage = level * 5;
            return damage;
        }

        /// <summary>
        /// Reduces character's health by the input amount 
        /// </summary>
        /// <param name="amount"> takes in an int </param>
        public virtual void TakeDamage(int amount)
        {
            health -= amount;
        }

        /// <summary>
        /// Asks if the character is ready to flee based on their health value
        /// </summary>
        /// <returns> returns true if under 50% health, else returns false </returns>
        public virtual bool ReadyToFlee()
        {
            if (health >= health / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// An overridden method that will return a sentence
        /// based on the stats of the character
        /// </summary>
        /// <returns> a unique string depending on the characters stats </returns>
        public override string ToString()
        {
            return $"{name} is level {level} and has {health} health left.";
        }
    }
}
