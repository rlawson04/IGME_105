namespace PE_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initializing variables
            string userInput = "";
            int numberOfCharacters = 0;
            string userChoice = "";

            //Greet the user and prompt how many names will be collected
            Console.WriteLine("Welcome to the character name collector!");
            Console.Write("How many character names are you entering? ");
            
            //take user input and parse to an int
            userInput = Console.ReadLine().Trim();
            numberOfCharacters = int.Parse(userInput);

            //create an array for the user names to be put into 
            string[] characterNames = new string[numberOfCharacters];
            
            //for loop to go through each of the values that the user can enter
            for (int i = 0; i < numberOfCharacters; i++)
            {
                Console.Write($"Name {i + 1}: ");
                characterNames[i] = Console.ReadLine().Trim().ToUpper(); 
            }
            
            //ended statement plus line break
            Console.WriteLine("All names have been entered.\n");

            while (userChoice != "QUIT")
            {
                Console.WriteLine("Choose from one of the following choices:\n" +
                   "\t- Name SEARCH\n" +
                   "\t- HOW MANY names start with 'B'\n" +
                   "\t- QUIT the program\n");
                Console.Write("Your choice: ");
                userChoice = Console.ReadLine().Trim().ToUpper();

                switch (userChoice)
                {
                    //If the user chose print, call the print method and write all names 
                    case "PRINT":
                        Print(characterNames);
                        Console.WriteLine();
                        break;

                    //If the user chose search, ask for a name and then use the search
                    //method to check if it is in the array.
                    case "SEARCH":
                        Console.WriteLine("Enter a name to search for: ");
                        string userName = Console.ReadLine().ToUpper().Trim();
                        if (Search(characterNames, userName))
                        {
                            Console.WriteLine($"Yes, {userName} is in the array\n");
                        }
                        else
                        {
                            Console.WriteLine($"No, {userName} is not in the array\n");
                        }
                        break;

                    //If the user chose how many, it will call the StartWithB method
                    //and return how many names start with the letter B.  
                    case "HOW MANY":
                        Console.WriteLine($"{StartWithB(characterNames)}" +
                            $" names start with the B\n");
                            break;

                    //The user choice will be set to QUIT which will
                    //end the above while loop
                    case "QUIT":
                        break;

                    //Default in case anything else is entered
                    default:
                        Console.WriteLine("That's not an option. Try again.\n");
                        break;
                }
                


            }
            Console.WriteLine("Goodbye!");
        }

        /// <summary>
        /// Takes names from user and prints them out
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        public static void Print(string[] nameArray)
        {
            for (int i = 0; i < nameArray.Length; i++)
            {
                Console.WriteLine(nameArray[i]);
            }
            return;
        }

        /// <summary>
        /// searches the list of character names
        /// </summary>
        /// <param name="hasValue"></param>
        /// <returns></returns>
        public static bool Search(string[] nameArray, string name)
        {
            //Check if the name entered by the user is contained in the array
            //If it is, return true. If it isn't, return false.
            if (nameArray.Any(name.Contains))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /// <summary>
        /// checks how many names start with b
        /// </summary>
        /// <param name="howMany"></param>
        /// <returns></returns>
        public static int StartWithB(string[] nameArray)
        {
            int namesStartingWithB = 0;

            //For loop goes through each name entered in the array and checks 
            //if the first letter is a B or b, using the StartsWith method.
            for (int i = 0; i < nameArray.Length; i++)
            {
                if (nameArray[i].StartsWith('B') || nameArray[1].StartsWith('b'))
                {
                    namesStartingWithB++;
                }
            }
            return namesStartingWithB;
            
        }
    }
}