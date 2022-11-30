// Reilly Lawson
// 11/30/2022
// Practice Exercise Using 2D Arrays

namespace PE_26_2D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] intArray = new int[2, 4];

            int col = intArray.GetLength(0);
            int row = intArray.GetLength(1);

            Random myrng = new Random();
            Fill2DArray(intArray, myrng, 0, 101);
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(intArray[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // --------------------------------------
        // Methods
        // --------------------------------------
        
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
    }
}