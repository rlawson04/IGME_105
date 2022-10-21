namespace RBL_GDAPS1_Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vars to be used throughout Main
            string userInput = " ";
            int userInt = 0;
            double userGrade = 0.0;

            //Print out the GetMenuOption until userInt is changed to 4
            while (userInt != 4)
            {

                //Prints the GetMenuOption method until case 4 is chosen
                switch (GetMenuOption())
                {
                    //If the user chose 1 ask for a grade and then return the 
                    //letter grade based on their response
                    case 1:
                        Console.WriteLine();
                        Console.Write("Enter a grade: ");
                        userGrade = double.Parse(Console.ReadLine());

                        //User grade is a ?? when less than or equal to 0.0
                        if (userGrade <= 0.0)
                        {
                            Console.WriteLine($"A grade of {userGrade} is a ??\n");
                        }

                        //User grade is Y when more then 0.0 but less than or equal to 40.0
                        if (userGrade > 0.0 && userGrade <= 40.0)
                        {
                            Console.WriteLine($"A grade of {userGrade} is a Y\n");  
                        }

                        //User grade is a Z when more than 40.0 but less than or equal to 100.0
                        if(userGrade > 40.0 && userGrade <= 100)
                        {
                            Console.WriteLine($"A grade of {userGrade} is a Z\n");
                        }

                        //User grade is ?? when more than 100.0
                        if(userGrade > 100.0)
                        {
                            Console.WriteLine($"A grade of {userGrade} is a ??\n");
                        }
                        break;

                    //If the user chose 2 tell them
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Chose 2\n");
                        break;

                    //If the user chose 3 tell them
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Chose 3\n");
                        break;

                    //If the user chose 4, say goodbye and change userInt
                    //to four so the while loop stops
                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Goodbye!\n");
                        userInt = 4;
                        break;
                }
            }

            
            
        }//End of Main

        /// <summary>
        /// Prints out a custom menu that the user inputs a value for one of 
        /// four unique outputs
        /// </summary>
        /// <returns></returns>
        public static int GetMenuOption()
        {
            //Variables for method
            string userInput = " ";
            int userInt = 0;

            //Main Printed section
            Console.WriteLine("Select one of the following options:");
            Console.WriteLine("    1. Assign grades with if statements");
            Console.WriteLine("    2. Sum the first N even numbers");
            Console.WriteLine("    3. Create, populate, and list an array");
            Console.WriteLine("    4. Quit");
            Console.Write("Enter a number (1-4): ");
            
            //Take user input, and parse to int
            userInput = Console.ReadLine().Trim();
            userInt = int.Parse(userInput);
            
            //Check that the user's number is between 1 and 4
            //Reprompt if it is not
            while (userInt < 1 || userInt > 4)
            {
                Console.Write("Invalid Option. Try again: ");
                userInput = Console.ReadLine().Trim();
                userInt = int.Parse(userInput);
            }
            //Return the user's number if it is valid
                return userInt;
            
        }


        public static 
    }//End of Program
}