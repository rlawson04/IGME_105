using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
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
        private Random random = new Random();

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
            names = this.names = new List<string> ();
            Random random = new Random ();
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
            Console.WriteLine($"{owner}'s backpack contents:");
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Removes item from the specified index  
        /// or throws an error if the index is out of range 
        /// </summary>
        /// <param name="index"></param>
        /// <returns> returns the item from the user inputed index </returns>
        public string GetItemInSlot(int index)
        {
            // Throws the error if the index is out of range of the list
            if (index < 0 || index > names.Count)
            {
                throw new Exception($"The specified index {index}" +
                    $" is out of the range 0 to {names.Count}");
            }
            
            string item = names.ElementAt(index);
            // Removes the item at a valid index from the backpack
            
            names.RemoveAt(index);
            return item;
        }

        /// <summary>
        /// Removes a randomly chosen item from the list and returns that item
        /// </summary>
        /// <returns> the item removed or an error message that the bag was empty </returns>
        public string GetRandomItem()
        {
            // Generates a random number between 0 and the length of the list
            int number = random.Next(0, names.Count);

            // Throws an exception if the list is empty
            if (names.Count == 0)
            {
                throw new Exception($"Cannot return item from {owner}'s empty bag");
            }
            string item = names.ElementAt(number);

            // Removes the item at the random index and then returns the items name
            names.RemoveAt(number);
            return item;
        }
    }
}
