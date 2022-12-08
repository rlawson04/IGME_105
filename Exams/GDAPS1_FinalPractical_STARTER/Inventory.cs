using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDAPS1_FinalPractical
{
    /// <summary>
    /// Inventory class that contains a list of items as 
    /// well as several methods to interact with that list
    /// </summary>
    internal class Inventory
    {
        //----------------------------------
        // Fields
        //----------------------------------

        List<Item> items;

        //----------------------------------
        // Properties
        //----------------------------------

        // NONE

        //----------------------------------
        // Constructors
        //----------------------------------


        public Inventory()
        {
            items = new List<Item>();
        }

        //----------------------------------
        // Methods
        //----------------------------------

        /// <summary>
        /// Adds the given instance of an item to the inventory's list
        /// </summary>
        /// <param name="itemToAdd"> an instance of an item
        /// to be added to the list</param>
        public void AddItem(Item itemToAdd)
        {
            items.Add(itemToAdd);
        }

        /// <summary>
        /// Prints out how many items are in the inventory 
        /// and then each individual item
        /// </summary>
        public void PrintSummary()
        {
            // Printed every time
            Console.WriteLine($"The inventory currently has {items.Count} item(s):");

            // Prints each element of the items list
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("\t" + items[i].ToString());
            }

            // Variable to keep track of weight
            double totalWeight = 0;

            // Loops through all items and adds up their weight
            for (int i = 0; i < items.Count; i++)
            {
                totalWeight += items[i].Weight;
            }

            Console.WriteLine("Total weight: {0:F2}", totalWeight);

            // Variables to keep track of number of weapons and their combined damage
            int numberOfWeapons = 0;
            int totalDamage = 0;

            // Adds all the weapons and their damages to respective variables
            foreach (Item i in items)
            {
                // Checks if the item is a weapon
                if (i is Weapon)
                {
                    // Downcast item to a weapon to access properties
                    Weapon weapon = (Weapon)i;

                    // Increment number of weapons
                    numberOfWeapons++;

                    // Add to the total damage
                    totalDamage += weapon.Damage;
                }
            }


            // Prints the number of weapons and their combined damage
            Console.WriteLine($"Total damage possible from the {numberOfWeapons}" +
                $" weapon(s): {totalDamage}");

        }// End of Print Summary

        /// <summary>
        /// Reads a given file and adds each item to its respective sub class
        /// </summary>
        /// <param name="filename"> a proper file name with either 
        /// Weapon or Food as the first word of each line</param>
        public void LoadItems(string filename)
        {
            try
            {
                // Opens the file
                StreamReader reader = new StreamReader(filename);

                // Keeps track of what was read from the file
                string lineOfText = " ";

                // While each new line isn't blank, loop 
                while (lineOfText != null)
                {
                    // Reads in the new line
                    lineOfText = reader.ReadLine();

                    if (lineOfText == null)
                    { break; }

                    string[] splitData = lineOfText.Split(',');

                    // Checks if the element is a weapon, creates an instance of it,
                    // and then adds it to the inventory's list of items
                    if (splitData[0] == "Weapon")
                    {
                        Weapon weapon = new Weapon(splitData[1],
                            int.Parse(splitData[2]),
                            double.Parse(splitData[3]));

                        items.Add(weapon);
                    }

                    // Checks if the element is food, creates an instance of it,
                    // and then adds it to the inventory's list of items
                    if (splitData[0] == "Food")
                    {
                        Food food = new Food(splitData[1],
                            int.Parse(splitData[2]),
                            double.Parse(splitData[3]));
                        items.Add(food);
                    }


                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Uh oh: " + ex.Message);
            }
        }

        /// <summary>
        /// Removes any weapons over 100 pounds and eats a serving of every food.
        /// If that was the last serving of the food, remove it.
        /// </summary>
        public void LightenLoad()
        {
            // Goes through each Item in the list
            for (int i = 0; i < items.Count; i++)
            {
                // Checks if item is a weapon
                if (items[i] is Weapon)
                {
                    // Downcast Item to weapon
                    Weapon weapon = (Weapon)items[i];

                    // Checks if the weapon is too heavy, if it is, drop it
                    if(weapon.Weight > 100)
                    {
                        Console.WriteLine($"Dropping {weapon} It's too heavy.");
                        items.Remove(weapon); 
                    }
                }

                // Checks if item is food
                if (items[i] is Food)
                {
                    // Downcast Item to food
                    Food food = (Food)items[i];

                    // Eats a serving of food
                    food.Eat();

                    // Checks if there is any more left, if not drop it
                    if (food.Weight == 0)
                    {
                        Console.WriteLine($"Dropping {food} It's all gone.");
                        items.Remove(food);

                        // Make sure not to skip since elements are being removed
                        i--;
                    }
                }
            }

        }

    }
}
