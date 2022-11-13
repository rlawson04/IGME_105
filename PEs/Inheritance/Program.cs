namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two monster objects from the monster class
            Monster monster1 = new Monster();
            Monster monster2 = new Monster("Josh Allen", 26, 100.5, true);

            // Print information of default monster
            monster1.PrintMonster();
            
            Console.WriteLine();

            // Print information of parameterized monster
            monster2.PrintMonster();

            Console.WriteLine();

            // Call properties on default monster
            Console.WriteLine($"{monster1.Name} has " +
                $"{monster1.Constitution} constitution. Is it animated?" +
                $" {monster1.CurrentlyAnimated}");

            // Call properties on parameterized zombie
            Console.WriteLine($"{monster2.Name} has " +
                $"{monster2.Constitution} constitution. Is it animated?" +
                $" {monster2.CurrentlyAnimated}");

            Console.WriteLine();

            // Create a new zombie object
            Zombie zombie = new Zombie("Rob", 36, 100);

            // Print information of parameterized zombie
            zombie.PrintZombie();

            Console.WriteLine();

            // Uses all four properties to print out information about zombie object
            Console.WriteLine($"{zombie.Name} has {zombie.Constitution} constitution." +
                $" Is it animated? {zombie.CurrentlyAnimated}");
            Console.WriteLine($"{zombie.Name}'s rate of decay is {zombie.RateOfDecay}");

            Console.WriteLine();

            // Create a new vampire object
            Vampire vampire = new Vampire("Dracula", 496, 100);

            // Print information of parameterized vampire
            vampire.PrintVampire();

            Console.WriteLine();

            // Uses all five properties to print out information about vampire object
            Console.WriteLine($"{vampire.Name} has {vampire.Constitution} constitution." +
                $" Is it animated? {vampire.CurrentlyAnimated}");
            Console.WriteLine($"{vampire.Name}'s rate of hunger is {vampire.RateOfHunger}." +
                $" {vampire.Name} is in {vampire.Form} form.");

            Console.WriteLine();

            // day passes three times for the zombie 
            for (int i = 0; i < 3; i++)
            {
                zombie.DayPasses();
            }

            // Re prints information after three days
            zombie.PrintZombie();

            Console.WriteLine();

            // day passes five times for the vampire
            for (int i = 0; i < 5; i++)
            {
                vampire.DayPasses();
            }

            // Re prints information after five days
            vampire.PrintVampire();

        }
    }
}