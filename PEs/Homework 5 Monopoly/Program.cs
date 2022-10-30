namespace Homework_5_Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables to be used throughout the program
            int sumOfDice = 0;

            //Initialize dice class
            Dice dice = new Dice();

            for (int i = 0; i < 100; i++)
            {
                
                Console.Write($"{dice.RollDie()} ");
                
            }
            Console.WriteLine($"Average roll for a single die: {sumOfDice/100}");
        }
    }
}