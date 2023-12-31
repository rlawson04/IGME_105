﻿namespace MagicEightBall_STARTER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables for the program
            string userChoice = "";
            string owner = "";

            MagicEightBall eightBall = new MagicEightBall();

            // Initial welcome statement
            Console.WriteLine("Welcome to the Magic 8 Ball simulator!");
            Console.Write("Who owns this ball? ");
            owner = Console.ReadLine();

            // Initialize parameterized constructor
            eightBall = new MagicEightBall(owner);

            // Menu item that loops based on user's choice
            do
            {
                // Present user with options
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.Write("You can 'shake' the ball, get a 'report', or 'quit': ");
                userChoice = Console.ReadLine().Trim().ToLower();

                if (userChoice == "shake")
                {
                    // Get the user's question
                    Console.Write(
                        " > {0}, what is your question? ",
                        owner);
                    string userQuestion = Console.ReadLine();

                    // Start the answer
                    Console.WriteLine(
                        " > Let's see what the ball says to your question \"{0}\"...",
                        userQuestion);

                    // Call Shake()  to initialize the eightBallSays variable
                    string eightBallSays = eightBall.ShakeBall();
                    Console.WriteLine(" > The Magic 8 ball says: " + eightBallSays);
                }
                else if (userChoice == "report")
                {
                    // Call Report()  to initialize the eightBallSays variable
                    string reportFromBall = eightBall.Report();
                    Console.WriteLine(" > " + reportFromBall);
                }
                else if (userChoice == "quit")
                {
                    // Print a goodbye message
                    Console.WriteLine(
                        "Goodbye {0}! Thanks for playing!",
                        owner);
                }
                else
                {
                    // Notify user their choice was invalid
                    Console.WriteLine(
                        " > {0}, I do not recognize that response.",
                        owner);
                }
            }
            while (userChoice != "quit");
        }
    }
}