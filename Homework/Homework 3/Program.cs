//Reilly Lawson
//9/30/22
//Golf and superman

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            double velocity = 0;
            double angle = 0;
            double distanceToTarget = 751;
            string userInput = " ";

            //Introduction to game
            Console.WriteLine("Welcome to artillery golf !");
            Console.WriteLine("Your goal is to hit a target that is 751 meters away \n");
            visualDivider();
            
            //PsuedoCode 
            /* while the distance is more than .5, run the code
             * Ask for cannon angle. If less than 0 or mnore than 90, error and ask again
             * 
             * 
             */
            while (distanceToTarget > 0.5)
            {
                Console.WriteLine("Enter the cannons angle (between 0 and 90)");
                userInput = Console.ReadLine();
                angle = double.Parse(userInput);

                if (angle < 0 || angle > 90)
                {
                    Console.WriteLine("Invalid!");
                    Console.WriteLine("Enter the cannons angle (between 0 and 90)");
                    userInput = Console.ReadLine();
                    angle = double.Parse(userInput);
                }
            }
        }
        /// <summary>
        /// Visual divider to break up the code
        /// </summary>
        public static void visualDivider()
        {
        Console.WriteLine("==========================================");
        }
    }
}