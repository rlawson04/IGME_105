using System.Security.Cryptography;

namespace Homework_5_Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables to be used throughout the program
            double sumOfDice = 0.0;

            //Initialize dice class
            Dice dice = new Dice();

            // 100 dice rolls, keeping track of each role in the sum of dice double
            for (int i = 0; i < 100; i++)
            {
                int value = dice.RollDie();
                sumOfDice += value;
                Console.Write($"{value} ");
            }
            Console.WriteLine();

            // Uses the sum of dice double to find the average of all the rolls
            Console.WriteLine($"Average roll for a single die: {sumOfDice/100}\n");


            // 100 rolls of two dice again using sum of dice double to keep track
            for (int i = 0; i < 100; i++)
            {
                int value = dice.RollDice(2);
                sumOfDice += value;
                Console.Write($"{value} ");

            }
            Console.WriteLine();

            // Again uses the sum of dice double to find the average of all the rolls
            Console.WriteLine($"Average roll for a single die: {sumOfDice / 100}\n");

            // Instantiates a new monopoly object called board
            Monopoly board = new Monopoly(100_000, 25, dice);

            // Pass the Analyze method into the PrintResults method
            board.PrintResults(board.Analyze());

        }// End of Main

    }//End of Program
}