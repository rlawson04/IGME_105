//Reilly Lawson
//9/26/2022
//Demo using Loops

namespace LoopsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region while loop
            VisualDivider();
            //while loop from 1 to 10

            //loop control variable
            int loopCounter = 0;

            //number displayed in the output
            int numberToPrint = 3;

            while (loopCounter < 7)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;


                Console.WriteLine(numberToPrint);
                numberToPrint += 3;

                loopCounter++;

                Console.ResetColor();
                //numberToPrint++;
                //numberToPrint = numberToPrint + 1;
            }
            #endregion

            #region Do While Loop
            VisualDivider();
            //Do-While 1 through 10
            int doLoopControl = 1;
            do
            {
                Console.WriteLine(doLoopControl);
                doLoopControl++;
            }
            while (doLoopControl <= 10);

            string userInput = "";
            do
            {
                Console.Write("Do you want to END? YES or NO? ");
                userInput= Console.ReadLine().ToUpper().Trim();
            }
            while (userInput != "YES");
            #endregion

            #region Loop through string

            //Doing on Wednesday

            #endregion
            /*
            string userInput = "";
            int parsedValue;

            Console.Write("Enter a number between 1 and 10: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            userInput = Console.ReadLine();
            parsedValue = int.Parse(userInput);
            Console.ResetColor();

            //Loop works while the loop is true
            //The loop is broken when the loop is false
            while ( parsedValue < 1 || parsedValue > 10)
            {
                Console.Write("Incorrect! Enter a number between 1 and 10! ");
                Console.ForegroundColor= ConsoleColor.DarkCyan;
                userInput = Console.ReadLine();
                parsedValue = int.Parse(userInput);
                Console.ResetColor();
            
            }
            Console.WriteLine("Thanks");
            */


        } //End of Main

        public static void VisualDivider()
        {
            Console.WriteLine("------------------------------------------------");
        }

    } //End of program
}