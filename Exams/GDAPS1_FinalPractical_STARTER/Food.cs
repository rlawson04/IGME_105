using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDAPS1_FinalPractical
{
    /// <summary>
    /// Specific item type that inherits from the item base class
    /// while having its own unique fields and method as well as an overriden property
    /// </summary>
    internal class Food : Item
    {
        //----------------------------------
        // Fields
        //----------------------------------

        private int numberOfServings;
        private double poundsPerServing;

        //----------------------------------
        // Properties
        //----------------------------------

        /// <summary>
        /// Get only property that overrides the 
        /// abstract weight property allowing access outside of class
        /// and calculates the weight of the food
        /// </summary>
        public override double Weight
        {
            get { return (numberOfServings * poundsPerServing); }
        }

        //----------------------------------
        // Constructors
        //----------------------------------

        /// <summary>
        /// Parameterized constructor that takes in
        /// number of servings as well as pounds per serving
        /// in addition to the name
        /// </summary>
        /// <param name="name"> what the food is called </param>
        /// <param name="numberOfServings"> how many servings of the food there are </param>
        /// <param name="poundsPerServing"> how much each serving of food weighs </param>
        public Food(string name, int numberOfServings, double poundsPerServing) : base(name)
        {
            this.numberOfServings = numberOfServings;
            this.poundsPerServing = poundsPerServing;
        }

        //----------------------------------
        // Methods
        //----------------------------------

        /// <summary>
        /// Adds the number of servings to the base to String method
        /// </summary>
        /// <returns> The foods name, weight, and number of servings </returns>
        public override string ToString()
        {
            return base.ToString() + $" and has {numberOfServings} servings.";
        }

        /// <summary>
        /// Either eats a serving and prints out a message or 
        /// lets the user know that no more servings remain
        /// </summary>
        public void Eat()
        {
            // When there are no more servings
            if (numberOfServings == 0)
            {
                Console.WriteLine($":( There is no {Name} left to eat.");
            }

            // When there are servings remaining 
            else
            {
                Console.WriteLine($"Mmmm I ate a serving of {Name}.");
                numberOfServings--;
            }
        }
    }
}
