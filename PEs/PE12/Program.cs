//Reilly Lawson
//9/28/2022
//Loops and GitHub practice exercise
namespace PE12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var to keep track of loop iterations
            int loopCounter = 20;
            
            Divider();
      
            //loop that prints 20 - 23 each on a seperate line
            while (loopCounter < 24)
            {
                Console.WriteLine(loopCounter);
                loopCounter++; 
            }
            Divider();

            //while loop that prints 20 - 23 on the same line
            loopCounter = 20;
            while (loopCounter < 24)
            {
                Console.Write(loopCounter + " ");
                loopCounter = loopCounter + 1;
            }
            Console.WriteLine();
            Divider();

            //do while that also prints 20 - 23 on same line
            loopCounter = 20;
            do
            {
                Console.Write(loopCounter + " ");
                loopCounter = loopCounter + 1;
            }
            while (loopCounter < 24);
            Console.WriteLine();
            Divider();

            //for loop that uses a new int to print 20 - 23 on the same line
            loopCounter = 20;
            for (int i = 20; i < 24; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Divider();

            //do while loop that prints 25, 35, 45, 55, 65, and 75 with commas
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

            //for loop that prints the individual letters of the word candy 
            string word = "CANDY";
            int length = word.Length;

            Console.WriteLine($"The word is {word}");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(word[i]);
                length = i;
                
            }
            Divider();

            //while loop that takes user input and repeats until user enters stop
            string userInput = "";

            while (userInput != "STOP")
            {
                Console.Write("Enter a word: ");
                userInput = Console.ReadLine().ToUpper().Trim();

                if (userInput == "STOP")
                {
                    Console.WriteLine("Okay!");
                }
            }
            Divider();

            //for loop that takes four double values from user and adds them up 
            double sumOfValues = 0;
            double userValue = 0;

            for (int i =0; i < 4; i++)
            {
                Console.Write("Enter a number: ");
                userInput = Console.ReadLine();
                userValue = double.Parse(userInput);

                sumOfValues = sumOfValues + userValue;
            }
            Console.WriteLine(sumOfValues);
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