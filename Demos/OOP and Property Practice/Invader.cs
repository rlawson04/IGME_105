using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_and_Property_Practice
{
    internal class Invader
    {
        // ------------------------------------------------
        // Fields
        // ------------------------------------------------

        private string location;
        private int health;
        private int endurance;
        private int threat;


        // ------------------------------------------------
        // Property
        // ------------------------------------------------

        /// <summary>
        /// Read Only property for health
        /// </summary>
        public int Health
        {
            get { return health; }
        }

        /// <summary>
        /// Read Only property for Location
        /// </summary>
        public string Location
        {
            get { return location; }
        }

        /// <summary>
        /// Read Only property for Endurance
        /// </summary>
        public int Endurance
        {
            get { return endurance; }
        }

       
        /// <summary>
        /// Read and Write property that changes the contents of threat
        /// if the value passed in is 5 or greater.
        /// </summary>
        public int Threat
        {
            get
            {
                return threat;
            }

            set
            {
                if (value >= 5)

                {
                    threat = value;
                }
            }
        }

        /// <summary>
        /// Boolean property that checks if the invaders health is above 0
        /// </summary>
        public bool IsNeutralized
        {
            get
            {
                if (health > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }   
        }

        /// <summary>
        /// Boolean property that checks if the invader is a major threat
        /// </summary>
        public bool IsMajorThreat
        {
            get
            {
                if(threat >= 4 && endurance >=7)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }
        // ------------------------------------------------
        // Constructor
        // ------------------------------------------------

        /// <summary>
        /// Parameterized constructor that takes two ints and one string
        /// </summary>
        /// <param name="location"></param>
        /// <param name="endurance"></param>
        /// <param name="threat"></param>
        public Invader (string location, int endurance, int threat)
        {
            this.location = location;
            this.endurance = endurance;
            this.threat = threat;
            health = 100;
        }

        // ------------------------------------------------
        // Method
        // ------------------------------------------------

        /// <summary>
        /// Method that subtracts an (int - endurance) from the invader's health
        /// </summary>
        /// <param name="damage"></param>
        public void RecieveDamage(int damage)
        {
            health -= (damage - endurance);
        }

        /// <summary>
        /// Method that heals invader if it is below 50 health, then returns true
        /// if health is above 50, returns false.
        /// </summary>
        /// <returns></returns>
        public bool Heal ()
        {
            if (health <= 50)
            {
                health += health / 5;
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
