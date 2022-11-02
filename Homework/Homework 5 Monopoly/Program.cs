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

            for (int i = 0; i < 100; i++)
            {
                int value = dice.RollDie();
                sumOfDice += value;
                Console.Write($"{value} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Average roll for a single die: {sumOfDice/100}\n");

            for (int i = 0; i < 100; i++)
            {
                int value = dice.RollDice(2);
                sumOfDice += value;
                Console.Write($"{value} ");

            }
            Console.WriteLine();
            Console.WriteLine($"Average roll for a single die: {sumOfDice / 100}");



        }// End of Main

    }//End of Program
}