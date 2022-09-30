//Reilly Lawson
//9/30
//Nested loops

namespace Nested_Loop_Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                    Console.Write(".");
            }
            Console.Write("\n");
        }
    }
}