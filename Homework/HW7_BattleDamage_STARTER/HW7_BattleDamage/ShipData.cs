using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_BattleDamage
{
    /// <summary>
    /// Base class for the ship child class that will inherit basic information for all ships
    /// </summary>
    internal class ShipData
    {
        // --------------------------------------------------------
        // Fields
        // --------------------------------------------------------

        protected string[,] data;

        // --------------------------------------------------------
        // Properties
        // --------------------------------------------------------

        /// <summary>
        /// Get only property that returns 0 or the number of rows if data has been loaded
        /// </summary>
        public int Count
        {
            get 
            { 
                // If no data has been loaded then return 0
                if (data.GetLength(0) == 0)
                {
                    return 0;
                }

                // Return the number of rows if data has been loaded 
                return data.GetLength(0);
            }
        }

        // --------------------------------------------------------
        // Methods
        // --------------------------------------------------------

        /// <summary>
        /// Reads data from the file and fills a 2d Array with information
        /// </summary>
        public void LoadData()
        {
            
            try 
            {
                // Opens the file as a stream reader
                StreamReader reader = new StreamReader("../../../shipstats.csv");
                
                // Variable to keep track of the individual lines and read the first line 
                string lineOfText = reader.ReadLine();

                // Turns the first line of the file into an int
                int numberOfRows = int.Parse(lineOfText);
               
                // Initialize data field and create the 2d array
                data = new string[numberOfRows, 6];
                
                // Reads second line which is not saved
                lineOfText = reader.ReadLine();

                // Integer to keep track of what row of the 2d array
                // is currently being filled
                int row = 0;

                // While the reader doesn't hit a null statement, keep reading
                while (lineOfText != null)
                {
                    lineOfText = reader.ReadLine();

                    // Breaks the loop if it picks up that lineOfText is null after
                    // it reads the next line
                    if (lineOfText == null)
                    {
                        break;
                    }

                    // Splits the data into an array
                    string[] arrayOfLines = lineOfText.Split(',');

                    // For loop that adds the split data into the 2d array
                    for (int col = 0; col < data.GetLength(1); col++)
                    {
                        data[row, col] = arrayOfLines[col];
                    }
                    
                    // Updates the row so that the 2d array can properly fill
                    row++;
                }
                
                // Closes the file when done
                reader.Close();

                // Prints how many rows were read
                Console.WriteLine($"{data.GetLength(0)} records read from shipstats.csv");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }// End of Load Data Method

        /// <summary>
        /// Copies the data of a specific row from the 2D array that was loaded
        /// </summary>
        /// <param name="row"> takes an int </param>
        /// <returns> A copy of a specific row of data </returns>
        public string[] GetShipData(int row)
        {
            string[] copyOfData = new string[6];
            try {    
                
                // Iterate through each index in the given row
                // and add it to the new array
                for(int i = 0; i < data.GetLength(1); i++)
                {
                    copyOfData[i] = data[row, i];
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"The specified row {row} is out" +
                    $" of the range of 0 to {data.GetLength(1)-1}");
            }

            // Return the new array with the row information
            return copyOfData;
        } // End of get ship data method

        /// <summary>
        /// Overrides the to string method to return the 2D array in a nice format
        /// </summary>
        /// <returns> returns a table with all the information of each ship </returns>
        public override string ToString()
        {
            // Variables to keep track of colums and rows, and the string to be
            // returned at the end of the method
            int numRows = data.GetLength(0);
            int numCols = data.GetLength(1);
            string arrayInfo = $"Faction Name\tShip Name\tWeapon\tAgility\tHull\tShields\n";

            // Iterate through the array, each ship and their stats
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                   // Add the information to the string 
                   arrayInfo += (data[row, col] + "\t");
                }
                // Make a new line for the next row in the array
                arrayInfo += "\n";
            }

            // Return the final string
            return arrayInfo;
        }
    }
}
