using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_File_IO_PE
{
    internal class Enemy
    {
        // -----------------------------------------------
        // Fields
        // -----------------------------------------------

        private string name;
        private int damage;


        // -----------------------------------------------
        // Properties
        // -----------------------------------------------

        // -----------------------------------------------
        // Constructors
        // -----------------------------------------------

        /// <summary>
        /// Basic parameterized constructor
        /// </summary>
        /// <param name="name"> takes in a string </param>
        /// <param name="damage"> takes in an int </param>
        public Enemy(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        // -----------------------------------------------
        // Methods
        // -----------------------------------------------

        /// <summary>
        /// Prints out the private fields to the console
        /// </summary>
        /// <returns> name and damage as a string </returns>
        public string Print()
        {
            return $"Name: {name}.      Damage: {damage}.";
        }

        /// <summary>
        /// Prints out the information in a computer readable way
        /// </summary>
        /// <returns> name,damage to be split later </returns>
        public override string ToString()
        {
            return $"{name},{damage}";
        }
    }
}
