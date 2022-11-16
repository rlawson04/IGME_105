using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Backpack_PE
{
    /// <summary>
    /// Backpack class.
    /// Students will write the contents of this class themselves.
    /// </summary>
    internal class Backpack
    {
        // ****************************************************************
        // Fields
        // ****************************************************************

        private string owner;
        private List<string> names;
        private Random random;

        // ****************************************************************
        // Properties
        // ****************************************************************

        /// <summary>
        /// Read-only property for getting the owners name
        /// </summary>
        public string Owner
        {
            get { return owner; }   
        }

        // ****************************************************************
        // Constructors
        // ****************************************************************

        /// <summary>
        /// Parameterized constructor of the backpack class
        /// </summary>
        /// <param name="owner"> takes a string from user </param>
        public Backpack (string owner)
        {
            this.owner = owner;
            names = new List<string> ();
            random = new Random ();
        }

        // ****************************************************************
        // Methods
        // ****************************************************************

        /// <summary>
        /// Adds the user's item to the backpack
        /// </summary>
        /// <param name="item"> user inserted string </param>
        public void AddToPack (string item)
        {
            Console.WriteLine($"{item} was added to {owner}'s backpack");
            names.Add (item);
        }

        /// <summary>
        /// Prints out the contents of the pack
        /// </summary>
        public void PrintPackContents()
        {
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
        }


    }
}
