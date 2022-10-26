using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginning_OOP
{
    /// <summary>
    /// This is the first class we have created!
    /// This represents a single player in a game.
    /// </summary>
    internal class Player
    {
        //-------------------------------------------------------------------
        //Fields are listed first in a class
        //They start with the keyword "private"
        //These are the class variables that describe an object (its data)
        //-------------------------------------------------------------------

        private string name;
        private int level;
        private string weapon;
        private string specialAbility;
        private Random rng;

        //-------------------------------------------------------------------
        //Constructor(s) 
        //Should assign every field a value!
        //-------------------------------------------------------------------

        //Default constructor that occurrs when nothing is entered into the constructor
        public Player()
        {
            name = "Nikki";
            level = 3;
            weapon = "flail";
            specialAbility = "Burning hands";
            rng = new Random();
        }
        
        // Parameterized constructor that has parameters passed in
        /// <summary>
        /// Constructor got a player object
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="playerLevel"></param>
        /// <param name="playerWeapon"></param>
        /// <param name="playerAbility"></param>
        public Player(string playerName, int playerLevel, string playerWeapon, string playerAbility)
        {
            name = playerName;
            level = playerLevel;
            weapon = playerWeapon;
            specialAbility = playerAbility;
            rng = new Random();
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="playerWeapon"></param>
        public Player(
            string playerName,
            string playerWeapon)
        {
            //Assign all of the 4 fields a value!
            //The value comes from the 4 parameters of this constructor
            this.name = playerName;
            this.weapon = playerWeapon;
            level = 1;
            specialAbility = "none";
            rng = new Random();
        }
        //-------------------------------------------------------------------
        // Methods are listed last in the class
        // They should (for now) start with the access modifier public 
        //-------------------------------------------------------------------

        
        /// <summary>
        /// Prints information about a Player object
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Weapon: " + weapon);
            Console.WriteLine("Special Ability: " + specialAbility);
        }

        /// <summary>
        /// Randomly generates an attack value between 4 and 49 (inclusive)
        /// </summary>
        /// <returns> Attack damage </returns>
        public int Attack()
        {
            //Can attack for any value from 4 through 49. NOT 50!
            return rng.Next(4, 50);
        }

        public void TakeDamage(int damage)
        {
            // Pretend we are doing something to the player's health\
            // As if we had a player health var (player health = player health - damage;)
        }
    }
}
