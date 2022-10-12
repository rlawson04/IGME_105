//Reilly Lawson
//9/30/22
//Loops practice

namespace PE13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loopCounter = 0;

            Console.WriteLine("While 1-10, skips every multiple of 4");
            while (loopCounter <= 10)
            {
                if (loopCounter % 4 == 0)
                {
                    loopCounter++;
                }

                Console.WriteLine(loopCounter);
                loopCounter++;
            }
            Divider();

            Console.WriteLine("For 100 to 80, odds only \n");
            for (int i = 100; i > 80; i--)
            {
                if ((i % 2) == 0)
                {
                    i--;
                }
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Divider();

            Console.WriteLine("For, 2-7. Even or odd? \n");
            for (int i = 2; i < 8;  i++)
            {
                if ((i % 2) == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(i + " even");
                    Console.ResetColor();
                }
                if (i % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(i + " odd");
                    Console.ResetColor();

                }

            }
            Divider();

            string word = "leEt speak";
            string newString = "";
            Console.WriteLine("For. Replacing characters, and adding spaces");
            Console.WriteLine($"Original string: {word}");
            Console.Write("New string:");

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'l':
                        newString += "1 ";

                        break;

                    case 'e':
                        newString += "3 ";

                        break;

                    case 'E':
                        newString += "3 ";

                        break;

                    case 'a':
                        newString += "4 ";

                        break;

                    case 't':
                        newString += "7 ";

                        break;

                    case ' ':
                        break;

                    default:
                        newString += word[i] + " ";

                        break;

                }                 
            }
            Console.Write(newString);
            Divider();

            Part2();
        }
        /// <summary>
        /// Creates a visual break between loops
        /// </summary>
        public static void Divider()
        {
            Console.WriteLine("======================================");
        }

        public static void Part2 ()
        {

        }
    }
}