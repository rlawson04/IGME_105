//Reilly Lawson
//9/28/2022
//Loops and GitHub practice exercise
namespace PE12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int loopCounter = 20;
            Divider();
            while (loopCounter < 24)
            {
                Console.WriteLine(loopCounter);
                loopCounter++; 
            }
            Divider();

            loopCounter = 20;
            while (loopCounter < 24)
            {
                Console.Write(loopCounter + " ");
                loopCounter = loopCounter + 1;
            }
            Console.WriteLine();
            Divider();

            loopCounter = 20;
            do
            {
                Console.Write(loopCounter + " ");
                loopCounter = loopCounter + 1;
            }
            while (loopCounter < 24);
            Console.WriteLine();
            Divider();

            loopCounter = 20;
            for (int i = 20; i < 24; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Divider();

            loopCounter = 25;
            do
            {
                Console.Write(loopCounter);
                if (loopCounter < 75)
                {
                    Console.Write(", ");
                }

                loopCounter = loopCounter + 10;
            }
            while (loopCounter <= 75);
            Console.WriteLine();
            Divider();

            string word = "CANDY";
            int length = word.Length;

            Console.WriteLine($"The word is {word}");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(word[i]);
                length = i;
                
            }
            Divider();
        }
        
        /// <summary>
        /// Creates a visual barrier between lines of code
        /// </summary>
        public static void Divider ()
        {
            
            Console.WriteLine("======================================");
        }
    }
}