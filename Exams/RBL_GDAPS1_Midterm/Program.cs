namespace RBL_GDAPS1_Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vars to be used throughout Main
            int loopInt = 0;
            double userGrade = 0.0;

            //Print out the GetMenuOption until loopInt is changed to 4
            while (loopInt != 4)
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
                        if (userGrade > 40.0 && userGrade <= 100)
                        {
                            Console.WriteLine($"A grade of {userGrade} is a Z\n");
                        }

                        //User grade is ?? when more than 100.0
                        if (userGrade > 100.0)
                        {
                            Console.WriteLine($"A grade of {userGrade} is a ??\n");
                        }
                        break;

                    //Uses the SumEvenNumbers method to return the first 3, 5, and 25
                    //even numbers in 3 C.WL statements
                    case 2:

                        Console.WriteLine();
                        Console.WriteLine($"The sum of the first 3 numbers is {SumEvenNumbers(3)}.");
                        Console.WriteLine($"The sum of the first 5 numbers is {SumEvenNumbers(5)}.");
                        Console.WriteLine($"The sum of the first 25 numbers is {SumEvenNumbers(25)}.\n");
                        break;

                    //Initiialize an array and fill with the first 6 odd numbers
                    //Then display them in descending order
                    //Then display 2 to the power of each number
                    case 3:
                        
                        //Initializing and filling the array
                        int[] numbers = new int[6];
                        numbers[0] = 0;
                        for (int i = 0; i < 6; i++)
                        { 
                            numbers[i] = i * 2 + 1;
                        }

                        Console.WriteLine();
                        
                        //Displaying each odd number from 11 to 1
                        for (int i = 5; i >= 0; i--)
                        {
                            Console.WriteLine($"numbers[{i}] is {numbers[i]}");
                        }

                        Console.WriteLine();
                        
                        //Print two to the power of each of the first 6 odd numbers
                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine($"2 to the {numbers[i]} is {Math.Pow(2, numbers[i])}");
                        }

                        Console.WriteLine();
                        break;

                    //If the user chose 4, say goodbye and change loopInt
                    //to four so the while loop stops
                    case 4:

                        Console.WriteLine();
                        Console.WriteLine("Goodbye!\n");
                        loopInt = 4;
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

        /// <summary>
        /// Method that takes an input of n, then finds the sum of the first n even numbers
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumEvenNumbers(int n)
        {
            //Variable for the value returned at the end
            int result = 0;
           
            //iterate n times where n is the integer passed through the method
            for (int i = 0; i <= n; i++)
            {
                result += 2 * i;
            }

            //return the result after the loop iterates through n times
            return result;
        }
    }//End of Program
}