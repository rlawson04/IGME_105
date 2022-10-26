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

        //-------------------------------------------------------------------
        //Constructor(s) 
        //Should assign every field a value!
        //-------------------------------------------------------------------

        /*
        public Player()
        {
            name = "Nikki";
            level = 3;
            weapon = "flail";
            specialAbility = "Burning hands";
        }
        */
        public Player(string playerName, int playerLevel, string playerWeapon, string playerAbility)
        {
            name = playerName;
            level = playerLevel;
            weapon = playerWeapon;
            specialAbility = playerAbility;
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

    }
}
