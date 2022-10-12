//Reilly Lawson
//9/30
//Nested loops

namespace Nested_Loop_Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inter loop runs all the way and then the outer loop runs once.
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Console.Write(".");
                }

                Console.Write("\n");
            }

            for (int r = 0; r < 15; r++)
            {
                for (int c = 0; c < 15; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
}