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

            // Uses all four parameters to print out information about zombie object
            Console.WriteLine($"{zombie.Name} has {zombie.Constitution} constitution." +
                $" Is it animated? {zombie.CurrentlyAnimated}");
            Console.WriteLine($"{zombie.Name}'s rate of decay is {zombie.RateOfDecay}");

        }
    }
}