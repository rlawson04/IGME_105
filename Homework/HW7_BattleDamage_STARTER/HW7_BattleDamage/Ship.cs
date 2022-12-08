using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HW7_BattleDamage
{
    /// <summary>
    /// Ship child class that inherits everything from the ShipData base class
    /// in addition to having its own unique fields and methods
    /// </summary>
    internal class Ship : ShipData
    {
        // --------------------------------------------------------
        // Fields
        // --------------------------------------------------------

        private string faction;
        private string name;
        private int mainWeapon;
        private int agility;
        private int hull;
        private int shields;
        private Random random;

        // --------------------------------------------------------
        // Properties
        // --------------------------------------------------------

        /// <summary>
        /// Get only property that returns the name of the ship
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        // --------------------------------------------------------
        // Constructors
        // --------------------------------------------------------

        /// <summary>
        /// parameterized constructor that takes a string array and
        /// turns it into the stats for the initialized ship
        /// </summary>
        /// <param name="data"> string array </param>
        /// <param name="rng"> instance of random </param>
        public Ship(string[] data, Random random)
        {
            this.faction = data[0];
            this.name = data[1];
            this.mainWeapon = int.Parse(data[2]);
            this.agility = int.Parse(data[3]);
            this.hull = int.Parse(data[4]);
            this.shields = int.Parse(data[5]);
            this.random = random;
        }

        // --------------------------------------------------------
        // Methods
        // --------------------------------------------------------

        /// <summary>
        /// Overrides the to string method and returns the
        /// information about the ship
        /// </summary>
        /// <returns> information about the ship </returns>
        public override string ToString()
        {
            return $"Faction: {faction} Name:{name} " +
                $"Main Weapon: {mainWeapon} Agility: {agility} " +
                $"Hull:{hull} Shields: {shields}";
        }

        /// <summary>
        /// Rolls a certain number of dice and adds together the attacks
        /// </summary>
        /// <param name="range"> a string </param>
        /// <returns> the total value of the attack </returns>
        public int GetAttackValue(string range)
        {
            // Sanitizes the input
            range = range.ToUpper().Trim();
            
            // Keeps track of the total attack
            int attack = 0;

            int attackWithoutMods = 0;

            // When distance is short, it adds one die which is seen as 
            // <= to main weapon
            if (range == "SHORT")
            {
                // Iterates through and adds the attack value of each roll
                for (int i = 0; i <= mainWeapon; i++)
                {
                    attackWithoutMods = random.Next(1,9);
                    
                    // Critical hit
                    if (attackWithoutMods == 1)
                    {
                        attack += 2;
                        Console.Write("Critical hit!\t");
                    }
                    // Regular hit
                    else if (attackWithoutMods > 1 && attackWithoutMods < 5)
                    {
                        attack += 1;
                        Console.Write("Regular hit!\t");
                    }
                    // Miss
                    else
                    {
                        attack += 0;
                        Console.Write("Miss!\t");
                    }

                }
            }
            // When distance is long or medium, the number of dice is the same
            else
            {
                // Iterates through and adds the attack value of each roll
                for (int i = 0; i < mainWeapon; i++)
                {
                    attackWithoutMods = random.Next(1, 9);

                    // Critical hit
                    if (attackWithoutMods == 1)
                    {
                        attack += 2;
                        Console.Write("Critical hit!\t");
                    }
                    // Regular hit
                    else if (attackWithoutMods > 1 && attackWithoutMods < 5)
                    {
                        attack += 1;
                        Console.Write("Regular hit!\t");
                    }
                    // Miss
                    else
                    {
                        attack += 0;
                        Console.Write("Miss!\t");
                    }

                }
            }

            // Return the attack value after the calculations
            return attack;
        }

        /// <summary>
        /// Calculates what gets blocked 
        /// </summary>
        /// <param name="range"> takes a string </param>
        /// <returns> returns the total of defense </returns>
        public int GetDefenseValue(string range)
        {
            // Sanitizes the input
            range = range.ToUpper().Trim();

            // Keep track of the total defense
            int defense = 0;

            // Check the generated number
            int genNumber = 0;

            // If range is long, add a die
            if (range == "LONG")
            {
                for (int i = 0; i <= agility; i++)
                {
                    genNumber = random.Next(1, 9);

                    // Evade
                    if (genNumber >= 1 && genNumber < 4)
                    {
                        Console.Write("No effect!\t");
                        defense += 1;
                    }
                    // No effect
                    else
                    {
                        Console.Write("Evade!\t");
                        defense += 0;
                    }
                }
            }
            // If range is short or medium, keep the dice
            else
            {
                for (int i = 0; i < agility; i++)
                {
                    genNumber = random.Next(1, 9);

                    // Evade
                    if (genNumber >= 1 && genNumber < 4)
                    {
                        Console.Write("Evade!\t");
                        defense += 1;
                    }
                    // No effect
                    else
                    {
                        Console.Write("No effect!\t");
                        defense += 0;
                    }
                }
            }

            // Returns the defense after calculation
            return defense;
        }

        /// <summary>
        /// Deals damage to the shields until they break, 
        /// then deals it directly to the hull
        /// </summary>
        /// <param name="damage"> an int </param>
        public void TakeDamage(int damage)
        {
            if (shields > damage)
            {
                shields -= damage;
                
            }
            else
            {
                hull -= damage - shields;
                shields = 0;
            }
        }
        
        /// <summary>
        /// Checks if the ship has been destroyed
        /// </summary>
        /// <returns> true or false depending on the 
        /// current hull and shields values</returns>
        public bool IsDestroyed()
        {
            if (hull <= 0 && shields == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
