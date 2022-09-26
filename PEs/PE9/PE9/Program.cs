namespace PE9
{
    internal class Program
    {

        //        public static void Questions()
        //        //Vars
        //        int value1;
        //        int RealAnswer2 = 28;

        //        Console.WriteLine("What is {0: C1} * 5?")
        //        answer2 = Console.ReadLine()

        //                if(answer2 == RealAnswer2)
        //                {
        //                    Console.WriteLine(“That’s right!”);
        //    }
        //    Else
        //{
        //    Console.WriteLine($”You said { answer2 }, did you mean $28 ?”);

        public static void Questions()
        {
            #region Question 1
            //PSUEDOcode
            //Ask user for answer to question
            //If correct go onto next question
            //If wrong, stop

            //TO DO
            //Format question
            //Sanitize response 
            //Use String.Format

            //vars
            double number1 = 5;
            string number1String = number1.ToString("C2");
            string number2 = "10";
            string userNumber;
            double userNumberAsDouble;

            //Asks question, and recieves user info
            Console.WriteLine($"what is {number1String} * {number2}?");
            userNumber = Console.ReadLine().Trim();

            //Parses user info to double so that the == operator can compare it
            userNumberAsDouble = double.Parse(userNumber);

            string userProvidedNumberString = userNumberAsDouble.ToString("C2");

            //Create two responses to user input
            //Case 1 is correct, case 2 is incorrect
            string numberResponse1 = String.Format($"{userProvidedNumberString}" +
                $" is correct!");

            string numberResponse2 = String.Format($"{userProvidedNumberString}" +
                $" is not quite right.");

            if (userNumberAsDouble == 50 || userNumberAsDouble == 50.0)
            {
                Console.WriteLine(numberResponse1);
            }
            else
            {
                Console.WriteLine(numberResponse2);
            }
            Console.WriteLine("------------------------------------------------");
            #endregion

            #region Question 2
            /*The user needs to enter information in an ascending order
             * i.e. 1,2,3 or a,b,c
             * if user inputs 1,2,3 CWL that's right
             * else if user inputs 3,2,1 CWL That's backwards
             * else CWL I don't recognize the pattern
             */
            //Vars for question 2
            string userWholeNumber1;
            string userWholeNumber2;
            string userWholeNumber3;
            int userWholeNumberAsInt1;
            int userWholeNumberAsInt2;
            int userWholeNumberAsInt3;

            Console.WriteLine("Enter 1-3 in **ascending** order");

            Console.Write("1: ");
            userWholeNumber1 = Console.ReadLine();
            userWholeNumberAsInt1 = int.Parse(userWholeNumber1);

            Console.Write("2: ");
            userWholeNumber2 = Console.ReadLine();
            userWholeNumberAsInt2 = int.Parse(userWholeNumber2);

            Console.Write("3: ");
            userWholeNumber3 = Console.ReadLine();
            userWholeNumberAsInt3 = int.Parse(userWholeNumber3);

            if (userWholeNumberAsInt1 == 1 && userWholeNumberAsInt2 == 2
                && userWholeNumberAsInt3 == 3)
            {
                Console.WriteLine("That's correct!");
            }
            else if (userWholeNumberAsInt1 >= 3 && userWholeNumberAsInt2 == 2
                && userWholeNumberAsInt3 < 2)
            {
                Console.WriteLine("That's backwards.");
            }
            else
            {
                Console.WriteLine("I don't recognize a pattern in your answer.");
            }
            Console.WriteLine("------------------------------------------------");
            #endregion

            #region Question 3

            /* Asks user a series of multiple choice questions 
             * Each answer is one of two cases, correct or incorrect
             * if correct, CWL Correct!
             * if incorrect, CWL that is not correct, correct answer:
             * else random input, CWL that was not an option
             */
            string userAnswer;

            //Question with all 4 parts plus a '>' character for the user cursor
            Console.WriteLine("Switches are best for ...");
           
            Console.WriteLine("\ta. Checking the status of a combination" +
                " of variables");
           
            Console.WriteLine("\tb. Checking for different discrete values" +
                " of the same variable");
           
            Console.WriteLine("\tc. Checking if a variables's value is within" +
                " a certain range");
           
            Console.WriteLine("\td. All of the above.");
            
            Console.Write("> ");
            userAnswer = Console.ReadLine().Trim().ToLower();

            //Take first character of answer which was already trimmed to lower
            char userAnswerChar = userAnswer[0];

            //Outcomes based on the case of the first letter
            switch (userAnswerChar)
            {
                case 'b':
                    Console.WriteLine("Correct!");
                    break;

                case 'a':
                case 'c':
                case 'd':
                    Console.WriteLine("Sorry. That's incorrect. Switches are best for checking");
                    Console.WriteLine("for differernt  *discrete values* of the *same* variable.");
                    break;
                default:
                    Console.WriteLine($"{userAnswer} is not an option.");
                    break;
            }

            //Thank the user for playing and change the color for fun
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Thank you for playing my game!");
            Console.WriteLine("Have a great day");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
        }

        static void Main(string[] args)
        {
            //Ask user if they want to play
            //if Yes || y, start question 1
            //if No || n, say okay, goodbye
            //if neither, say I do not recognize that response
            //Vars
            String answer1;


            Console.WriteLine("Do you want to play my game?");
            answer1 = Console.ReadLine().ToLower().Trim();

            if (answer1 == "yes" || answer1 == "y")
            {
                Console.WriteLine("--------------");
                Questions(); 
            }


            else if (answer1 == "no" || answer1 == "n")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Okay, goodbye!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("I do not recognize that input");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


    }
}