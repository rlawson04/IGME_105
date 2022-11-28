using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_25_Abstract
{
    abstract class Monster
    {
        //-------------------------------------------------
        // Fields
        //-------------------------------------------------

        protected string name;
        protected int health;
        protected string attackType;
        protected Random randomGenerator;

        //-------------------------------------------------
        // Properties
        //-------------------------------------------------

        /// <summary>
        /// Read-Only name
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Read and Write method that changes health to a
        /// lesser value that cannot be negative
        /// </summary>
        public int Health
        {
            get { return health; }
            set
            {
                if (value >= 0 && value < health)
                {
                    health = value;
                }
            }
        }
        //-------------------------------------------------
        // Constructors
        //-------------------------------------------------

        /// <summary>
        /// Parameterized constructor 
        /// </summary>
        /// <param name="name"> takes a string </param>
        /// <param name="health"> takes an int </param>
        /// <param name="attackType"> takes a string </param>
        
        public Monster
        (
            string name,
            int health,
            string attackType
        )
        {
            this.name = name;
            this.health = health;
            this.attackType = attackType;
            randomGenerator = new Random();

        }

        //-------------------------------------------------
        // Methods
        //-------------------------------------------------

        /// <summary>
        /// Attacks a target
        /// </summary>
        /// <param name="monster"> takes a monster object </param>
        public abstract void Attack(Monster monster);

        /// <summary>
        /// Takes damage of a specific amount and type
        /// </summary>
        /// <param name="damage"> takes an int </param>
        /// <param name="attackType"> takes a string </param>
        public abstract void TakeDamage(int damage, string attackType);

        /// <summary>
        /// An overriden ToString method that changes based on the attackType of the monster
        /// </summary>
        /// <returns> Unique String </returns>
        public override string ToString()
        {
            switch (attackType)
            {
                case "fire":
                return $"{name} has {health} health and breathes fire on its enemies";
                    break;

                case "ice":
                    return $"{name} has {health} health and freezes its enemies";
                    break;

                case "earth":
                    return $"{name} has {health} health and creates powerful earthquakes";
                    break;

                case "lightning":
                    return $"{name} has {health} health and summons lightning strikes";
                    break;

                default:
                    return name;
            }
        } 
    }

    
}
