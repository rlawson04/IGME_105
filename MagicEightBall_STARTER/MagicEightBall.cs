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



        // --------------------------------------------------------------------
        // Constructors of this class
        // --------------------------------------------------------------------

        // *****************************************
        // *** Add comments to this constructor! ***
        // *****************************************
        public MagicEightBall()
        {
            // Initialize the Random object and the responses array.
            randomGenerator = new Random();
            responses = new string[5];
            responses[0] = "It is certain";

            // *******************************************************
            // *** Assign 4 more responses to the responses array! ***
            // *******************************************************


            // *******************************************************
            // *** Assign default value to the owner               ***
            // *** and another default value to times shaken!      ***
            // *******************************************************

        }

        // *****************************************************
        // *** Create a parameterized constructor here!      ***
        // *** And add comments to it!                       ***
        // *****************************************************



        // --------------------------------------------------------------------
        // Methods of this class
        // --------------------------------------------------------------------


        // *****************************************
        // *** Add comments to this method!      ***
        // *****************************************
        public string ShakeBall()
        {
            // Randomly chooses one of the 5 possible responses
            // Next(0, 5) will return 0, 1, 2, 3, or 4.  
            int randomNumber = randomGenerator.Next(0, 5);

            // Retrieve that randomly chosen index from the responses array
            //   and save the value in a string variable.
            string randomResponse = responses[randomNumber];

            // *******************************************
            // *** Update times shaken!                ***
            // *******************************************


            // *******************************************
            // *** Return randomly chosen response!    ***
            // *******************************************

            // Change this to return the correct thing.
            return "";
        }


        // *****************************************************
        // *** Create the Report method here!                ***
        // *** And add comments to it!                       ***
        // *****************************************************



    }
}
