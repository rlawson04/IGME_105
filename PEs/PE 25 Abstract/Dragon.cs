using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_25_Abstract
{
    internal class Dragon : Monster
    {
        //-------------------------------------------------
        // Fields
        //-------------------------------------------------

        private string resistanceType;

        //-------------------------------------------------
        // Properties
        //-------------------------------------------------



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


    }
}
