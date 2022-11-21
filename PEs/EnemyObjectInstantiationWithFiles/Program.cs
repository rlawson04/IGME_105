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
            Console.WriteLine();

            // User menu loop that keeps going until menuQuit bool is true
            while (menuQuit == false)
            {
                Console.WriteLine("Choose one of the following options:" +
                    "\r\n1 - Enter Data\r\n2 - Save Data\r\n3 - Load Data");
                userInput = Console.ReadLine().Trim().ToUpper();

                switch (userInput)
                {
                    // User gives an integer and that many enemies and damages
                    // are added to their appropriate lists
                    case "ENTER DATA":
                        Console.WriteLine();
                        Console.Write("How many enemies are you adding? ");
                        int userInt = int.Parse(Console.ReadLine());
                        
                        // For loop for each added enemy
                        for (int i = 0; i < userInt; i++)
                        {
                            // Takes user inputed name and adds to the name list
                            Console.Write($"Enter enemy {i + 1} name: ");
                            names.Add(Console.ReadLine());

                            // Takes user inputed damage and adds to the damage list
                            Console.Write($"Enter enemy {i + 1} damage: ");
                            damages.Add(int.Parse(Console.ReadLine()));
                        }

                        Console.WriteLine();
                        break;

                    // Writes the users data from ENTER DATA onto a text file
                    // or states that nothing new can be saved
                    case "SAVE DATA":

                        // Checks that names list has content
                        if (names.Count == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("There is nothing to save.\n");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Saving enemy names to the file.");

                            // Opens stream writer and edits the enemies.txt file
                            StreamWriter writer = new StreamWriter("../../../" + fileName);

                            // Overwrites information with all the new names and damages
                            for (int j = 0; j < names.Count; j++)
                            {
                                writer.WriteLine(names.ElementAt(j) + ","
                                    + damages.ElementAt(j));
                            }
                            // When done with the file, close it
                            writer.Close();

                            Console.WriteLine("File saved.\n");
                        }
                        break;

                    // Reads the data that was writen above back out to the user
                    case "LOAD DATA":
                        Console.WriteLine();

                        // Checks if there are items in names.count
                        if(names.Count > 0)
                        {
                            names.Clear();
                            damages.Clear();
                        

                            StreamReader reader = new StreamReader("../../../" + fileName);
                            string lineOfText = " ";

                            // Reads the file until null is found
                            while (lineOfText != null)
                            {
                                lineOfText = reader.ReadLine();

                                if (lineOfText == null)
                                {
                                    break;
                                }

                                // Split data into an array of strings
                                string[] splitData = lineOfText.Split(',');

                                // Adds all the names into the list again 
                                for (int i = 0; i < splitData.Length; i += 2)
                                {
                                    names.Add(splitData[i]);
                                }

                                // Adds all the damages into the list again
                                for (int j = 1; j < splitData.Length; j += 2)
                                {
                                    damages.Add(int.Parse(splitData[j]));
                                }
                            }

                            // Prints all the names and the damages from the list
                            for (int i = 0; i < names.Count; i++)
                            {
                                Console.Write("Name: " + names.ElementAt(i) + " ");
                                Console.WriteLine("Damage: " + damages.ElementAt(i));
                            }
                            // Closes the file when done
                            reader.Close();
                            
                        }
                        else
                        {
                            Console.WriteLine("There are no player names to load.");
                        }

                        Console.WriteLine();
                        break;

                    // Exits the program's main while loop
                    case "QUIT":
                        menuQuit = true;
                        Console.WriteLine();
                        break;
                }

            } // End of menu

            // Farewell message
            Console.WriteLine("Goodbye!");

        }// End of main
    }// End of program
}