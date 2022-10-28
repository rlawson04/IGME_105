//Reilly Lawson
//10/24/2022
//Using Object Oriented Programming

namespace Beginning_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate (create instance of) a Player object
            //Classname identifier = new Classname();
            Player firstPlayer = new Player("Matthew", 2, "glaive", "Laser eyes");
            Player secondPlayer = new Player("Andrew", 1, "my hands", "Breathe fire");
            Console.WriteLine();

            firstPlayer.Print();
            secondPlayer.Print();

            // Use attack method to damage an object
            int attackDamageFromP1 = firstPlayer.Attack();
        }
    }
}