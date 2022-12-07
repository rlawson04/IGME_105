
// Erin Cascioli
// 11/30
// Demo: Multidimensional arrays

namespace Demo_MultidimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a multi-dimensional (2D array) array where the rows contain a name and birthday
            // Name     Birthday
            string[,] birthdays = new string[5, 2];
            int numRows = birthdays.GetLength(0);
            int numCols = birthdays.GetLength(1);

            // Add data to the 2D array
            birthdays[0,0] = "Andrew";              // Name
            birthdays[0,1] = "December 23";         // Date
            birthdays[1, 0] = "Emmett";             // Name
            birthdays[1, 1] = "December 16";        // Date
            birthdays[2, 0] = "Reilly";             // Name
            birthdays[2, 1] = "April 4";            // Date
            birthdays[3, 0] = "Jalen";              // Name
            birthdays[3, 1] = "October 29";         // Date
            birthdays[4, 0] = "Ayden";              // Name
            birthdays[4, 1] = "December 20";        // Date

            // Iterate through the array, printing each student's name and their birthday
            for(int row = 0; row < numRows; row++)
            {
                for(int col = 0; col < numCols; col++)
                {
                    Console.Write(birthdays[row, col] + "\t");
                }
                Console.WriteLine();
            }

            // Can still get index out of range!
            //Console.WriteLine(birthdays[5, 5]);
        }
    }
}