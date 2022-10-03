//Reilly Lawson
//9/30/22
//Golf and superman

using System;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            double velocity = 0;
            double angle = 0;
            double distanceToTarget;
            double flightTime = 0;
            double distanceTraveled = 0;
            double radians;
            double angleSin;
            double angleCos;
            double velocitySquared;
            double sinSquared;

            int iterationCounter = 1;
            string userInput = " ";


            //Introduction to game
            Console.WriteLine("Welcome to artillery golf !");
            Console.WriteLine("Your goal is to hit a target that is 751 meters away \n");
            visualDivider();

            //PsuedoCode 
            /* Ask for cannon angle. If less than 0 or mnore than 90, error and ask again
             * Ask for velocity. If less than 0, ask again
             * if the distance is more than .5, run the code again and add 1 to attempts
             * if after 10 attempts the user doesn't get close, end anyway
             */
            while (iterationCounter <= 10)
            {
                //Prints attempt number and then prompts user for angle
                Console.WriteLine($"Attempt {iterationCounter} -------------------- \n");
                Console.WriteLine("Enter the cannons angle (between 0 and 90)");
                userInput = Console.ReadLine();
                angle = double.Parse(userInput);

                while (angle < 0 || angle > 90)
                {
                    Console.WriteLine("Invalid!");
                    Console.WriteLine("Enter the cannons angle (between 0 and 90)");
                    userInput = Console.ReadLine();
                    angle = double.Parse(userInput);
                }
                Console.WriteLine();

                //Prompts user for initial velocity
                Console.WriteLine("Enter the canonball's initial velocity" +
                    " (positive number)");

                userInput = Console.ReadLine();
                velocity = double.Parse(userInput);

                while (velocity < 0)
                {
                    Console.WriteLine("Invalid!");
                    Console.WriteLine("Enter the canonball's initial velocity" +
                        " (positive number)");

                    userInput = Console.ReadLine();
                    velocity = double.Parse(userInput);
                }


                //Math using velocity and angle from user
                radians = (angle * Math.PI) / 180;
                angleSin = Math.Sin(radians);
                angleCos = Math.Cos(radians);
                sinSquared = Math.Pow(angleSin, 2);
                velocitySquared = Math.Pow(velocity, 2);
                distanceToTarget = 751;

                // (v * sin(θ) + (v2 * sin2(θ) + 20.0 * L * sin(θ) )1/2 ) / 10.0
                //v is velocity, theta is angle, l is 2.0
                flightTime = ((velocity * angleSin) +
                Math.Pow(velocitySquared * sinSquared + 20.0 * 2.0 * angleSin, 0.5));
                flightTime = flightTime / 10;

                //d = v * cos(θ) * t
                distanceTraveled = velocity * angleCos * flightTime;

                //calculate distance from target by getting the absolute
                //value of distanceToTarget - distanceTraveled
                distanceToTarget = Math.Abs(distanceToTarget - distanceTraveled);

                //Final statement of attempt
                Console.WriteLine("Thank you!");
                Console.WriteLine($"A canon ball with an initial velocity of {velocity} m/s,");
                Console.WriteLine($"at an angle of {angle} degrees from the ground, will strike");
                Console.WriteLine($"the ground {distanceTraveled} meters away.");
                Console.Write($"You're {distanceToTarget} meters from the target. ");

                //Ends game if user is accurate enough
                if (distanceToTarget < 0.5)
                {
                    Console.WriteLine("A sucessful hit!");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();

                    visualDivider();

                    //run superman jump code if they got close
                    superManJump();
                }
                iterationCounter++;
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("Thanks for playing!");
            Console.Write("Press any key to continue...");
            Console.ReadKey();

            //run superman jump after 10 attempts
            superManJump();
          
           

        }
        /// <summary>
        /// Visual divider to break up the code
        /// </summary>
        public static void visualDivider()
        {
        Console.WriteLine("==========================================");
        }

        public static void superManJump()
        {
            /*Prompt user for gravitational constant in feet/sec/sec (Pos)
            * Re prompt on an invalid input
            * Use user input in equation below
            * v^2 = 2*g*h where g is the user input and h is 660
            */

            //variables
            string userInput = "";
            double gravConstant;
            double superVelocity;
            double superVelocitySquared;
            //initial prompt
            Console.WriteLine("Your target building is 660 feet.");
            Console.WriteLine("Please enter the gravitational constant for the planet" +
                " which Superman");
            Console.WriteLine("is currently attempting this jump.");
            visualDivider();

            //start of loop statement 
            while (userInput != "N")
            {
                //take user input and parse to double
                Console.Write("Gravitational Constant: ");
                userInput = Console.ReadLine();
                gravConstant = double.Parse(userInput);

                //while the user input is negative, re-prompt
                while (gravConstant < 0)
                {
                    Console.WriteLine("Invalid! Must be positive number");
                    Console.Write("Gravitational Constant: ");
                    userInput = Console.ReadLine();
                    gravConstant = double.Parse(userInput);
                }

                //Formula using the user input
                superVelocitySquared = 2 * gravConstant * 660;

                //square root superVelocitySquared
                superVelocity = Math.Sqrt(superVelocitySquared);

                //print out final velocity
                Console.WriteLine($"Superman must jump with an initial velocity of " +
                    $"at least {superVelocity} \n");

                //Ask if they want to try again and sanitize input
                Console.Write("Would you like to test another value? Y or N: ");
                userInput = Console.ReadLine().ToUpper().Trim();

                Console.WriteLine();
            }
        }
    }
}