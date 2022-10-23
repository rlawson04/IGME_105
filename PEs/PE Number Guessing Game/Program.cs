//Reilly Lawson
//10/23/2022
//Using RNG and Tryparse to create a guessing game

namespace PE_Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vars to be used throughout the program
            Random RNG = new Random();
            int randomNum = RNG.Next(-1, 101);
            string userInput = " ";

            Console.WriteLine($"Random Number: {randomNum} ");
            Console.WriteLine();

            //Initial loop to run through 8 times or stop iuf
            for (int i = 1; i < 9; i++)
            {
                int result = -1;
                Console.Write($"Turn number {i}: Enter your guess: ");
                userInput = Console.ReadLine();
                bool success = int.TryParse(userInput, out result);
                
                //Again If the user is inputting a non int value, it reprompts them
                //while not changing the 
                while (!success)
                {
                    Console.WriteLine("Invalid Guess - try again\n");
                    Console.Write($"Turn number {i}: Enter your guess: ");
                    userInput = Console.ReadLine();
                    success = int.TryParse(userInput, out result);
                }

                //If the users input was valid, test if it is more or less than the 
                //random number, and print too high or too low respectively
                if (success)
                {
                    //while the users value is less than 0 or more than 100 reprompt them
                    while (result < 0 || result > 100)
                    {
                        Console.WriteLine("Invalid Guess - try again\n");
                        Console.Write($"Turn number {i}: Enter your guess: ");
                        userInput = Console.ReadLine();
                        success = int.TryParse(userInput, out result);

                        //reprompt if again the user inputs an invalid option
                        if(!success)
                        {
                            result = -1;
                        }
                    }

                    if (result > randomNum)
                    {                        
                        Console.WriteLine("Too high");
                        Console.WriteLine();
                    }
                    else if (result < randomNum)
                    { 
                        Console.WriteLine("Too low");
                        Console.WriteLine();
                    }

                }

                //If the user guesses the number correctly, change i to 9 so the loop stops
                //also print out how many turns it took them to win
                if (result == randomNum)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Correct! you won in {i} turns.");
                    i = 9;
                }
            }
        }
    }
}