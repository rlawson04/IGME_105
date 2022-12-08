using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDAPS1_FinalPractical
{
    /// <summary>
    /// Specific item type that inherits from the Item base class 
    /// while also having its own version of ToString Method and unique fields
    /// </summary>
    internal class Weapon : Item
    {
        //----------------------------------
        // Fields
        //----------------------------------

        private double weight;
        private int damage;

        //----------------------------------
        // Properties
        //----------------------------------

        /// <summary>
        /// Get only property to access damage field outside of class
        /// </summary>
        public int Damage
        {
            get { return damage; }
        }

        /// <summary>
        /// Get only property that overrides the 
        /// abstract weight property allowing access outside of class
        /// </summary>
        public override double Weight
        {
            get { return weight; }
        }

        //----------------------------------
        // Constructors
        //----------------------------------

        /// <summary>
        /// Parameterized constructor that inherits from the base class
        /// </summary>
        /// <param name="name"> name of the weapon </param>
        /// <param name="weight"> how heavy the weapon is </param>
        /// <param name="damage"> how much damage the weapon does </param>
        public Weapon(string name, int damage, double weight) : base (name)
        {
            this.damage = damage;
            this.weight = weight;

        }

        //----------------------------------
        // Methods
        //----------------------------------

        /// <summary>
        /// Overrides the base class' ToString Method, adding on weapon damage
        /// </summary>
        /// <returns> returns the name, weight, and damage of the weapon </returns>
        public override string ToString()
        {
            return base.ToString() + $", {damage} damage";
        }
    }
}
