// Reilly Lawson
// 11/30/2022
// Practice Exercise Using 2D Arrays

namespace PE_26_2D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Instance of random object
            Random myRNG = new Random();

            // Create an int array
            int[,] intArray = new int[2, 4];

            // Call Fill method on the array
            Fill2DArray(intArray, myRNG, 0, 101);

            // Call Print method on the array
            Print2DArray(intArray);
        }

        // --------------------------------------
        // Methods
        // --------------------------------------
        
        /// <summary>
        /// Fills a 2D array with random values between the two given ints
        /// </summary>
        /// <param name="array"> takes a 2D int array </param>
        /// <param name="generator"> takes a random </param>
        /// <param name="lowRange"> takes an int </param>
        /// <param name="highRange"> takes an int </param>
        public static void Fill2DArray(
            int[,] array, Random generator, int lowRange, int highRange)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = generator.Next(lowRange, highRange);
                }
            }
        }

        /// <summary>
        /// Prints the elements of a 2D array
        /// in a nice format with labeled rows and columns
        /// </summary>
        /// <param name="array"> takes an 2D int array </param>
        public static void Print2DArray(int[,] array)
        {
            // Variables to track the rows and columns of the above 2D array
            int col = array.GetLength(1);
            int row = array.GetLength(0);

            // Prints column number above each column
            for (int k = 0; k < col; k++)
            {
                Console.Write("\tColumn " + (k + 1));
            }

            // Moves the writer to the next line
            Console.WriteLine();

            // Iterates through the array and prints each element
            for (int i = 0; i < row; i++)
            {
                // Prints the row number before each row
                Console.Write("Row " + (i + 1));
                for (int j = 0; j < col; j++)
                {
                    Console.Write("\t" + array[i, j] + "\t");
                }

                // Break to seperate the rows
                Console.WriteLine();
            }
        }
    }
}