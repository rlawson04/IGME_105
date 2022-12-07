// Reilly Lawson
// 12/4/2022
// Using File IO to simulate a battle

using System;
using System.IO;
using System.Reflection.Metadata;

/// <summary>
/// Empty starter project with the shipstats.csv data file for HW 7
/// As configured, the relative path for shipstats.csv in this project is
///         "../../../shipstats.csv"
/// https://docs.google.com/document/d/1PZlqdP3MJlPMuIFZiztK-_R0iUy654XPnbFu85Xcuvo/edit?usp=sharing
/// </summary>
namespace HW7_BattleDamage
{
    class Program
    {
        static void Main(string[] args)
        {
            //====================================================
            // Test Code from part 2
            //====================================================
            /*
            Random rng = new Random();
            ShipData ships = new ShipData();
            ships.LoadData();

            List<Ship> oneOfEach = new List<Ship>();
            oneOfEach.Add(new Ship(ships.GetShipData(0), rng));
            oneOfEach.Add(new Ship(ships.GetShipData(2), rng));
            oneOfEach.Add(new Ship(ships.GetShipData(4), rng));
            oneOfEach.Add(new Ship(ships.GetShipData(6), rng));
            oneOfEach.Add(new Ship(ships.GetShipData(7), rng));

            foreach (Ship ship in oneOfEach)
            { 
                Console.WriteLine(ship);
            }

            oneOfEach.ElementAt(0).GetAttackValue("Short");
            oneOfEach.ElementAt(0).GetAttackValue("Medium");

            oneOfEach.ElementAt(0).GetDefenseValue("long");
            oneOfEach.ElementAt(0).GetDefenseValue("medium");

            oneOfEach.ElementAt(0).TakeDamage(10);
            Console.WriteLine(oneOfEach.ElementAt(0).ToString());
            Console.WriteLine(oneOfEach.ElementAt(0).IsDestroyed());
            */

            // Instance of random
            Random random = new Random();

            // Instance of ShipData
            ShipData data = new ShipData();

            // Load data into the ShipData instance
            data.LoadData();

            // Create a list with the two ships that will battle
            List<Ship> shipList = new List<Ship>();

            // Add two randomly chosen ships to the list
            shipList.Add( new Ship(data.GetShipData(random.Next(0,7)), random));
            shipList.Add(new Ship(data.GetShipData(random.Next(0, 7)), random));

            // Initial welcome statement
            Console.WriteLine("WELCOME TO THE BATTLE!");

            // Print information about the two ships
            Console.WriteLine("Ship 1: " + shipList.ElementAt(0));
            Console.WriteLine("Ship 2: " + shipList.ElementAt(1));

            // Variable for round counter
            int round = 1;

            // Variable for the range of attack
            string range = " ";

            // Loop until one ship is destroyed
            while (shipList.ElementAt(0).IsDestroyed() == false
                && shipList.ElementAt(1).IsDestroyed() == false)
            {
                // Print round number 
                Console.WriteLine("\n~~~~~~~~~~~~~~ Round " + round + " ~~~~~~~~~~~~~~");
                
                // First two rounds have long range
                if (round <= 3)
                {
                    range = "long";
                }
                // Next two rounds have medium range
                else if(round <= 5)
                {
                    range = "medium";
                }
                // Any following rounds are short
                else 
                {
                    range = "short";
                }

                // Print the attack message
                Console.WriteLine($"{shipList.ElementAt(0).Name} attacks," +
                    $" {shipList.ElementAt(1).Name} defends!");

                // Aligns attack messages to be slightly over
                Console.Write("\t");

                // Makes an int to keep track of the attack damage
                int ship1Attack = shipList.ElementAt(0).GetAttackValue(range);
                
                Console.WriteLine();
                Console.Write("\t");

                // Creates an int to keep track of the defense value
                int ship2Defense = shipList.ElementAt(1).GetDefenseValue(range);
                        
                Console.WriteLine();
                Console.Write("\t");

                int totalDamage = ship1Attack - ship2Defense;

                // Prints how much damage was sent and avoided
                Console.WriteLine($"{shipList.ElementAt(1).Name} avoided {ship2Defense} of" +
                    $" {shipList.ElementAt(0).Name} {ship1Attack} damage.");

                // Checks if the total damage is positive
                if (totalDamage > 0)
                {
                    Console.Write("\t");

                    //Prints the damage delivered if greater than 0 
                    Console.WriteLine("Total damage delivered: " + (totalDamage));
                    
                    // Has the opposite ship take damage
                    shipList.ElementAt(1).TakeDamage(totalDamage);
                }
                else
                {
                    Console.Write("\t");

                    Console.WriteLine("Total damage delivered: 0");
                }
                
                Console.WriteLine();
                
                // Print the attack message
                Console.WriteLine($"{shipList.ElementAt(1).Name} attacks," +
                    $" {shipList.ElementAt(0).Name} defends!");

                Console.Write("\t");

                // Makes an int to keep track of the attack damage
                int ship2Attack = shipList.ElementAt(1).GetAttackValue(range);

                Console.WriteLine();
                Console.Write("\t");

                // Creates an int to keep track of the defense value
                int ship1Defense = shipList.ElementAt(0).GetDefenseValue(range);

                Console.WriteLine();
                Console.Write("\t");

                // Prints how much damage was sent and avoided
                Console.WriteLine($"{shipList.ElementAt(0).Name} avoided {ship1Defense} of" +
                    $" {shipList.ElementAt(1).Name} {ship2Attack} damage.");
                
                // Calculates total damage
                totalDamage = ship2Attack - ship1Defense;

                if (totalDamage > 0)
                {
                    Console.Write("\t");

                    //Prints the damage delivered if greater than 0 
                    Console.WriteLine("Total damage delivered: " + (totalDamage));

                    // Has the opposite ship take damage
                    shipList.ElementAt(0).TakeDamage(totalDamage);
                }
                else
                {
                    Console.Write("\t");

                    Console.WriteLine("Total damage delivered: 0");
                }
                

                Console.WriteLine();


                // Prints the ships after combat has occured
                Console.WriteLine(shipList.ElementAt(0));
                Console.WriteLine(shipList.ElementAt(1));

                // Pause for 2 seconds
                System.Threading.Thread.Sleep(2000);

                // Increment rounds
                round++;
            }

            // Print the end of the battle
            Console.WriteLine("\n+++ THE BATTLE HAS FINISHED +++");

            // Print out who has won the battle if anyone
            if (shipList.ElementAt(0).IsDestroyed() == false 
                && shipList.ElementAt(1).IsDestroyed() == true)
            {
                Console.WriteLine(shipList.ElementAt(0).Name + " has won the battle!");
            }
            else if (shipList.ElementAt(0).IsDestroyed() == true 
                && shipList.ElementAt(1).IsDestroyed() == false)
            {
                Console.WriteLine(shipList.ElementAt(1).Name + " has won the battle!");
            }
            else
            {
                Console.WriteLine("Both ships have been destroyed!");
            }
        }
    }
}
