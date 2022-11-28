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


        //-------------------------------------------------
        // Methods
        //-------------------------------------------------
    }
}
