using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_Monopoly
{
    internal class Monopoly
    {
        //-------------------------------------------------
        // Fields
        //-------------------------------------------------
        private Dice dice;

        private String[] propertyNames = {
            "Go",
            "Mediterranean Avenue",
            "Community Chest (1)",
            "Baltic Avenue",
            "Income Tax",
            "Reading Railroad",
            "Oriental Avenue",
            "Chance (1)",
            "Vermont Avenue",
            "Connecticut Avenue",
            "Jail",
            "St. Charles Place",
            "Electric Company",
            "States Avenue",
            "Virginia Avenue",
            "Pennsylvania Railroad",
            "St. James Place",
            "Community Chest (2)",
            "Tennessee Avenue",
            "New York Avenue",
            "Free Parking",
            "Kentucky Avenue",
            "Chance (2)",
            "Indiana Avenue",
            "Illinois Avenue",
            "B&O Railroad",
            "Atlantic Avenue",
            "Ventnor Avenue",
            "Water Works",
            "Marvin Gardens",
            "Go To Jail",
            "Pacific Avenue",
            "North Carolina Avenue",
            "Community Chest (3)",
            "Pennsylvania Avenue",
            "Short Line Railroad",
            "Chance (3)",
            "Park Place",
            "Luxury Tax",
            "Boardwalk"
};

        private int numberOfPlayers;

        private int tripsAroundBoard;

        //-------------------------------------------------
        // Constructors
        //-------------------------------------------------

        /// <summary>
        /// Parameterized Constructor for the monopoly object
        /// </summary>
        /// <param name="numberOfPlayers"></param>
        /// <param name="tripsAroundBoard"></param>
        /// <param name="dice"></param>
        public Monopoly(int numberOfPlayers, int tripsAroundBoard, Dice dice)
        {
            this.numberOfPlayers = numberOfPlayers;
            this.tripsAroundBoard = tripsAroundBoard;
            this.dice = dice;
        }

        //-------------------------------------------------
        // Methods
        //-------------------------------------------------

        /// <summary>
        /// Iterates through 1000 players taking 1000 trips around the board
        /// and returns the percentage of landing on each space
        /// </summary>
        /// <returns></returns>
        public double[] Analyze()
        {
            int[] visits = new int[propertyNames.Length];
            double totalVisits = 0.0;
            int position = 0;
            

            // Iterates through all the players 
            for (int i = 0; i < numberOfPlayers; i++)
            {
                tripsAroundBoard = 0;
                // Iterates through 1000 trips around the board
                while (tripsAroundBoard < 25)
                {
                    position += dice.RollDice(2);

                    // When the players position is greater than 40 (past go), it adds
                    // one trip around the board and takes 40 away from the position
                    if (position >= 40)
                    {
                        position = position - 40;
                        tripsAroundBoard++;
                    }

                    // When the player lands on go to jail, they go past go to the jail
                    if (position == 30)
                    {
                        position = 10;
                        tripsAroundBoard++;
                    }

                    // Marks one to the position the player is on and one to total visits
                    visits[position]++;
                    totalVisits++;

                    
                }

               
            }

            // Makes a double array to hold the percentages of landing on the given spot
            // which is iterated through using a for loop
            double[] percentages = new double[propertyNames.Length];
            for (int j = 0; j < propertyNames.Length; j++)
            {
                percentages[j] = (visits[j] / totalVisits) * 100;
            }

            return percentages;
        }

        /// <summary>
        /// Takes a double array and prints out each board space followed by 
        /// the formatted percentage from the array
        /// </summary>
        /// <param name="visitPercentages"></param>
        public void PrintResults(double[] visitPercentages)
        {
            for (int i = 0; i < propertyNames.Length; i++)
            {
                Console.WriteLine(propertyNames[i] + ": {0:F2}", visitPercentages[i]);
            }
        }

    }// End of class
}
