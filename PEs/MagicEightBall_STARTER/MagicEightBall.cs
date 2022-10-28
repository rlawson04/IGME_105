using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicEightBall_STARTER
{
    internal class MagicEightBall
    {
        // --------------------------------------------------------------------
        // Fields of this class
        // --------------------------------------------------------------------

        // 2 included fields from the exercise
        private string[] responses;
        private Random randomGenerator;

        // *************************************************************
        // *** Put the other 2 fields (owner and times shaken) here! ***
        // *************************************************************

        private string owner;
        private int timesShaken;

        // --------------------------------------------------------------------
        // Constructors of this class
        // --------------------------------------------------------------------

        /// <summary>
        /// Default constructor 
        /// </summary>
        public MagicEightBall()
        {
            // Initialize the Random object and the responses array.
            randomGenerator = new Random();
            responses = new string[5];
            responses[0] = "It is certain";
            responses[1] = "No";
            responses[2] = "Not probable";
            responses[3] = "Of course";
            responses[4] = "Try again later";

            // *******************************************************
            // *** Assign default value to the owner               ***
            // *** and another default value to times shaken!      ***
            // *******************************************************
            owner = "Person";
            timesShaken = 0;
        }

        // *****************************************************
        // *** Create a parameterized constructor here!      ***
        // *** And add comments to it!                       ***
        // *****************************************************

        public MagicEightBall(string name)
        {
            randomGenerator = new Random();
            responses = new string[5];
            responses[0] = "It is certain";
            responses[1] = "No";
            responses[2] = "Not probable";
            responses[3] = "Of course";
            responses[4] = "Try again later";
            owner = name;
            timesShaken = 0;
        }

        // --------------------------------------------------------------------
        // Methods of this class
        // --------------------------------------------------------------------


        /// <summary>
        /// generates random number and chooses the mathing response
        /// </summary>
        /// <returns></returns>
        public string ShakeBall()
        {
            // Randomly chooses one of the 5 possible responses
            // Next(0, 5) will return 0, 1, 2, 3, or 4.  
            int randomNumber = randomGenerator.Next(0, 5);

            // Retrieve that randomly chosen index from the responses array
            //   and save the value in a string variable.
            string randomResponse = responses[randomNumber];

            timesShaken++;

            return randomResponse;
        }


        /// <summary>
        /// Reports the number of times the ball has been shaken
        /// returns different outputs depending on how many times it has 
        /// been shaken
        /// </summary>
        /// <returns></returns>
        public string Report()
        {
            //returns that it was shaken once or twice
            if (timesShaken == 1 || timesShaken == 2)
            {
                return $"{owner} has shaken the ball {timesShaken} times.";
            }

            //returns it was shaken 3 or more times
            if (timesShaken >= 3)
            {
                return $"{owner}  has shaken the ball {timesShaken} times. That’s a lot of questions!";
            }
            else
            {
                //returns when timesShaken is 0
                return $"{owner} has not shaken the ball yet";
            }
        }


    }
}
