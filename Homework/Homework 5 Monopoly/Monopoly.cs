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

        public double[] Analyze()
        {
            int[] visits = new int[propertyNames.Length];
            double totalVisits = 0.0;
            int position = 0;

            for (int i = 0; i < numberOfPlayers; i++)
            {
                
                while(position >= 40)
                {
                    position += dice.RollDice(2);
                    visits[position]++;

                }

                if (position >= 40)
                {
                    position = position - 40;
                }
            }

            return  ;
        }
    }// End of class
}
