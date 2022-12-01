using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace HW_6_Character_Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a random object, 2 archers, and 2 mages
            Random r = new Random();
            Mage Potter = new Mage("Potter", 150, 4, false, r);
            Mage Gandolf = new Mage("Gandolf", 90, 6, false, r);
            Archer Legolas = new Archer("Legolas", 120, 8, false, r);
            Archer Katniss = new Archer("Katniss", 100, 6, false, r);

            // Create list of characters and add all four of the above characters
            List<CommonCharacter> commonCharacters = new List<CommonCharacter>();
            commonCharacters.Add(Potter);
            commonCharacters.Add(Gandolf);
            commonCharacters.Add(Legolas);
            commonCharacters.Add(Katniss);

            // Introduce all characters using to string method
            Console.WriteLine("Contestants -------------------------------------------\n");
            Console.WriteLine(Potter.ToString() + "\n");
            Console.WriteLine(Gandolf.ToString() + "\n");
            Console.WriteLine(Legolas.ToString() + "\n");
            Console.WriteLine(Katniss.ToString() + "\n");

            int numberOfContestants = 4;
            int roundNumber = 1;
            // While Loop for the rounds fought
            while (numberOfContestants > 1)
            {
                // Print round number
                Console.WriteLine("Round " + roundNumber + " ----------------------------");
                
                for (int i = 0; i < commonCharacters.Count; i++)
                {
                    // Creates a target for each character to attack
                    int targetIndex = r.Next(0, commonCharacters.Count);
                    CommonCharacter target = commonCharacters.ElementAt(targetIndex);
                    
                    // Checks to make sure the character is not attacking itself
                    while (target == commonCharacters.ElementAt(i))
                    { 
                        targetIndex = r.Next(0, commonCharacters.Count);
                        target = commonCharacters.ElementAt(targetIndex);
                    }

                    // Int to keep track of damage 
                    int damage = commonCharacters.ElementAt(i).Attack();

                    // Main printed statement saying who is attacking whom and for how much
                    Console.WriteLine($"{commonCharacters.ElementAt(i).Name} attacks " +
                        $"{target.Name} for {damage}.");

                    // Call take damage method on the target to subtract their health
                    target.TakeDamage(damage);

                }

                // Break after attacks finish 
                Console.WriteLine();

                // Print out characters' health totals after taking damage
                for(int i = 0; i < numberOfContestants; i++)
                {
                    Console.WriteLine($"{commonCharacters.ElementAt(i).Name} has" +
                        $" {commonCharacters.ElementAt(i).Health} health left");
                }

                // Print out Casualties 
                Console.WriteLine("\n>> Casualties <<");
                for (int j = 0; j < numberOfContestants; j++)
                {
                    // Check if each character is ready to flee or if they are dead
                    // then print the corrosponding message or don't print anything
                    if (commonCharacters.ElementAt(j).ReadyToFlee() == true)
                    {
                        Console.WriteLine(commonCharacters.ElementAt(j).Name + " is ready to flee");
                        commonCharacters.RemoveAt(j);
                        numberOfContestants--;
                    }
                    else if (commonCharacters.ElementAt(j).IsDead == true)
                    {
                        Console.WriteLine(commonCharacters.ElementAt(j).Name + " has died");
                        commonCharacters.RemoveAt(j);
                        numberOfContestants--;
                    }
                }
                
                // Prompt user for input so battle isn't finished instantly
                Console.WriteLine("\n<Press ENTER to continue>\n");
                Console.ReadLine();

                roundNumber++;
            } // End of battle loop

            Console.WriteLine("**The battle has finished**");

            // Print victor if one character won, or print that no one survived
            if (numberOfContestants == 1)
            {
                Console.WriteLine(commonCharacters.ElementAt(0).Name + " has won the battle!");
            }
            else if (numberOfContestants == 0)
            {
                Console.WriteLine("No one survived the vicious battle");
            }
        }// End of main
    }
}