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

        // --------------------------------------------------------
        // Constructors
        // --------------------------------------------------------



        // --------------------------------------------------------
        // Methods
        // --------------------------------------------------------

        public static void LoadData()
        {
            
            try 
            {
                // Opens the file as a stream reader
                StreamReader reader = new StreamReader("../../../shipstats.csv");
                
                // Variable to keep track of the individual lines
                string lineOfText = " ";

                // Reads the first line of the file
                lineOfText = reader.ReadLine();

                // Turns the first line of the file into an int
                int numberOfRows = int.Parse(lineOfText);
               
                string[,] data = new string[numberOfRows, 6];

                while (lineOfText != null)
                {
                    lineOfText.Split(',');
                }
                
                // Closes the file when done
                reader.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
            
        
    }
}
