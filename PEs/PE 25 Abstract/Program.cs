// Reilly Lawson
// 11/28/2022
// Using Abstract keyword

namespace PE_25_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fight One
            // Creates an instance of the dragon class and the beholder class
            Dragon Jimmy = new Dragon("Jimmy", 25, "ice", "lightning");
            Beholder Carl = new Beholder("Carl", 90, "lightning", "ice");

            // To string method on both monsters
            Console.WriteLine(Jimmy.ToString());
            Console.WriteLine(Carl.ToString());

            // Variable to keep track of rounds
            int i = 1;

            // Loops through the attack method until
            // one of the monster's health values falls below 0
            while (Jimmy.Health > 0 && Carl.Health > 0)
            { 
                // Readability while looping
                Console.WriteLine();

                // Print round number
                Console.WriteLine("Round " + i);

                // Attack method on both monsters
                Jimmy.Attack(Carl);
                Carl.Attack(Jimmy);

                // Print health values after taking damage
                Console.WriteLine($"Jimmy's health is " + Jimmy.Health);
                Console.WriteLine($"Carl's health is " + Carl.Health);

                // Increase iteration number
                i++;
            }

            // Break to show the end of the fight
            Console.WriteLine();

            // Print out the winner depending on which monster's health has fallen below 0
            if (Carl.Health < 0 && Jimmy.Health > 0)
            {
                Console.WriteLine("Jimmy has emerged victorious!");
            }
            else if (Carl.Health < 0 && Jimmy.Health < 0)
            {
                Console.WriteLine("Both challengers have perished in the midst of battle");
            }
            else
            {
                Console.WriteLine("Carl has emerged victorious!");
            }
            #endregion

            #region Fight Two
            // Break to seperate the two fights
            Console.WriteLine();

            // Creates an instance of the dragon class and the beholder class
            Dragon Jeff = new Dragon("Jeff", 55, "earth", "fire");
            Beholder Bob = new Beholder("Carl", 90, "ice", "lightning");

            // To string method on both monsters
            Console.WriteLine(Jeff.ToString());
            Console.WriteLine(Bob.ToString());

            // Variable to keep track of rounds
            int j = 1;

            // Loops through the attack method until
            // one of the monster's health values falls below 0
            while (Jeff.Health > 0 && Bob.Health > 0)
            {
                // Readability while looping
                Console.WriteLine();

                // Print round number
                Console.WriteLine("Round " + j);

                // Attack method on both monsters
                Jeff.Attack(Bob);
                Bob.Attack(Jeff);

                // Print health values after taking damage
                Console.WriteLine($"Jeff's health is " + Jeff.Health);
                Console.WriteLine($"Bob's health is " + Bob.Health);

                // Increase iteration number
                j++;
            }

            // Break to show the end of the fight
            Console.WriteLine();

            // Print out the winner depending on which monster's health has fallen below 0
            if (Bob.Health < 0 && Jeff.Health > 0)
            {
                Console.WriteLine("Jeff has emerged victorious!");
            }
            else if (Bob.Health < 0 && Jeff.Health < 0)
            {
                Console.WriteLine("Both challengers have perished in the midst of battle");
            }
            else
            {
                Console.WriteLine("Bob has emerged victorious!");
            }

            #endregion
        }
    }
}