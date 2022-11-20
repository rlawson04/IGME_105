// Reilly Lawson
// 11/20/2022
// File IO PE

using System.Net.Http.Headers;

namespace Text_File_IO_PE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // New lists that hold names (string) and damages (int)
            List<string> names = new List<string>();
            List<int> damages = new List<int>();

            // Name of the text file initialized to a string 
            string fileName = "enemies.txt";

            // string for later user info
            string userInput = " ";

            // Boolean to control the user menu loop
            bool menuQuit = false;

            // Welcome message
            Console.WriteLine("Welcome to the Enemy Name Program");

            // User menu loop that keeps going until menuQuit bool is true
            while (menuQuit == false)
            {
                Console.WriteLine("Choose one of the following options:" +
                    "\r\n1 - Enter Data\r\n2 - Save Data\r\n3 - Load Data");
                userInput = Console.ReadLine().Trim().ToUpper();

                switch (userInput)
                {
                    case "ENTER DATA":
                        Console.WriteLine("How many enemies are you adding?");
                        int userInt = int.Parse(Console.ReadLine());
                        
                        // For loop for each added enemy
                        for (int i = 0; i < userInt; i++)
                        {
                            // Takes user inputed name and adds to the name list
                            Console.WriteLine($"Enter enemy {i + 1} name");
                            names.Add(Console.ReadLine());

                            // Takes user inputed damage and adds to the damage list
                            Console.WriteLine($"Enter enemy {i + 1} damage");
                            damages.Add(int.Parse(Console.ReadLine()));

                        }

                        break;

                    case "SAVE DATA":
                        break;

                    case "LOAD DATA":
                        break;

                    case "QUIT":
                        menuQuit = true;
                        break;
                }
            } // End of menu

            // Farewell message
            Console.WriteLine("Goodbye!");

        }// End of main
    }// End of program
}