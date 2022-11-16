namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Create two monster objects from the monster class
            Monster monster1 = new Monster();
            Monster monster2 = new Monster("Josh Allen", 26, 100.5, true);

            // Print information of default monster
            monster1.Print();
            
            Console.WriteLine();

            // Print information of parameterized monster
            monster2.Print();

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
            zombie.Print();

            Console.WriteLine();

            // Uses all four properties to print out information about zombie object
            Console.WriteLine($"{zombie.Name} has {zombie.Constitution} constitution." +
                $" Is it animated? {zombie.CurrentlyAnimated}");
            Console.WriteLine($"{zombie.Name}'s rate of decay is {zombie.RateOfDecay}");

            Console.WriteLine();

            // Create a new vampire object
            Vampire vampire = new Vampire("Dracula", 496, 100);

            // Print information of parameterized vampire
            vampire.Print();

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
            zombie.Print();

            Console.WriteLine();

            // day passes five times for the vampire
            for (int i = 0; i < 5; i++)
            {
                vampire.DayPasses();
            }

            // Re prints information after five days
            vampire.Print();
            */

            // Four instances of monsters with varying information
            Monster monsterA = new Monster("A", 75, 90, true);
            Monster monsterB = new Monster("B", 12, 73, false);
            Monster monsterC = new Monster("C", 46, 0, true);
            Monster monsterD = new Monster("D", 98, 0, false);

            // Prints out monsterA's information
            monsterA.Print();

            Console.WriteLine();

            // Monster B eats Princess Peach
            monsterB.Eat("Princess Peach");

            // Calls ToString method on all monsters. A and B explicitly, 
            // C and D in a C.WL statement
            Console.WriteLine(monsterA.ToString());
            Console.WriteLine(monsterB.ToString());
            Console.WriteLine(monsterC);
            Console.WriteLine(monsterD);
            Console.WriteLine();

            // Creates two instances of zombies 
            Zombie Guts = new Zombie("Guts", 26, 100);
            Zombie Munch = new Zombie("Munch", 39, 0);

            // Munch's info is printed 
            Munch.Print();
            Console.WriteLine();

            // Guts eats a koopa troopa
            Guts.Eat("Koopa Troopa");
            Console.WriteLine();

            // Calls to string on both zombies
            Console.WriteLine(Guts.ToString());
            Console.WriteLine(Munch.ToString());
            Console.WriteLine();

            // Creates three instances of bampires
            Vampire Kalon = new Vampire("Kalon", 1154, 53);
            Vampire Calantha = new Vampire("Calantha", 49, 20);
            Vampire Dragos = new Vampire("Dragos", 344, 0);


            // Prints Kalon's information
            Kalon.Print();
            Console.WriteLine();

            // Calantha shapeshifts and then eats a piranha plant
            Calantha.Shapeshift();
            Calantha.Eat("Piranha Plant");
            Console.WriteLine();

            // Dragos attempts to shapeshift
            Dragos.Shapeshift();
            Console.WriteLine();

            // Calls ToString on all vampires
            Console.WriteLine(Kalon.ToString());
            Console.WriteLine(Calantha.ToString());
            Console.WriteLine(Dragos.ToString());
            Console.WriteLine();

            // Creates a list of monsters and adds each monster initialized above
            List<Monster> monsters = new List<Monster>();
            monsters.Add(monsterA);
            monsters.Add(monsterB);
            monsters.Add(monsterC);
            monsters.Add(monsterD);
            monsters.Add(Guts);
            monsters.Add(Munch);
            monsters.Add(Kalon);
            monsters.Add(Calantha);
            monsters.Add(Dragos);

            // Iterates through each monster in the list
            foreach(Monster m in monsters)
            {
                // Prints the monsters information
                m.Print();
                
                // Checks if a given monster is a vampire, and then transforms them
                if (m is Vampire)
                {
                    Vampire vampire = (Vampire)m;
                    vampire.Shapeshift();
                    
                }

                // Checks if a given monster is a zombie, and then has them eat a goomba
                if (m is Zombie)
                {
                    Zombie zombie = (Zombie)m;
                    zombie.Eat("Goomba");
                }
                Console.WriteLine();
            }
        }
    }
}