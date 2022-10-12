
// **************************************************************************
// Reilly Lawson
// 10/12/2022
// Static methods starter file
// Purpose: Practice with writing static methods
// **************************************************************************


namespace Methods_STARTER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup variables necessary for testing all 6 methods
            bool success = false;
            int biggest = 0;
            string word = "";

            #region Method Tests in Main
            // **************************************************************************
            // Method #1 Testing                                                        *
            // TODO: Uncomment this while you are testing your first method             *
            // **************************************************************************
            /*
            Console.WriteLine(".......................................................");
            
            success = MakesTen(9, 10);
            Console.WriteLine(
                "Do the values 9 and 10 add to 10? OR is one of the numbers 10? {0}",
                success);

            success = MakesTen(9, 9);
            Console.WriteLine(
                "Do the values 9 and 9 add to 10? OR is one of the numbers 10? {0}",
                success);

            success = MakesTen(1, 9);
            Console.WriteLine(
                "Do the values 1 and 9 add to 10? OR is one of the numbers 10? {0}",
                success);
            Console.WriteLine(".......................................................");
            */


            // **************************************************************************
            // Method #2 Testing                                                        *
            // TODO: Uncomment this while you are testing your second method            *
            // **************************************************************************
            /*
            biggest = Largest(1, 2, 3);
            Console.WriteLine(
                "The largest value of 1, 2, and 3 is: {0}",
                           biggest);

            biggest = Largest(1, 3, 2);
            Console.WriteLine(
                "The largest value of 1, 3, and 2 is: {0}",
                           biggest);

            biggest = Largest(3, 2, 1);
            Console.WriteLine(
                "The largest value of 3, 2, and 1 is: {0}",
                           biggest);

            biggest = Largest(2, 1, 2);
            Console.WriteLine(
                "The largest value of 2, 1, and 2 is: {0}",
                           biggest);

            biggest = Largest(3, 3, 1);
            Console.WriteLine(
                "The largest value of 3, 3, and 1 is: {0}",
                           biggest);

            biggest = Largest(5, 5, 5);
            Console.WriteLine(
                "The largest value of 5, 5, and 5 is: {0}",
                           biggest);
            Console.WriteLine(".......................................................");
            */


            // **************************************************************************
            // Method #3 Testing                                                        *
            // TODO: Uncomment this while you are testing your third method             *
            // **************************************************************************
            /*
            word = NotString("candy");
            Console.WriteLine("Your string 'candy' is now: {0}", word);

            word = NotString("x");
            Console.WriteLine("Your string 'x' is now: {0}", word);

            word = NotString("not bad");
            Console.WriteLine("Your string 'not bad' is now: {0}", word);

            word = NotString("nothing");
            Console.WriteLine("Your string 'nothing' is now: {0}", word);
            Console.WriteLine(".......................................................");
            */


            // **************************************************************************
            // Method #4 Testing                                                        *
            // TODO: Uncomment this while you are testing your fourth method            *
            // **************************************************************************
            /*
            word = RemoveIndex("kitten", 1);
            Console.WriteLine("Your string 'kitten' removing 1 is now: {0}", word);

            word = RemoveIndex("kitten", 0);
            Console.WriteLine("Your string 'kitten' removing 0 is now: {0}", word);

            word = RemoveIndex("kitten", 5);
            Console.WriteLine("Your string 'kitten' removing 5 is now: {0}", word);

            word = RemoveIndex("kitten", 6);
            Console.WriteLine("Your string 'kitten' removing 6 is now: {0}", word);

            word = RemoveIndex("kitten", -1);
            Console.WriteLine("Your string 'kitten' removing -1 is now: {0}", word);
            Console.WriteLine(".......................................................");
            */


            // **************************************************************************
            // Method #5 Testing                                                        *
            // TODO: Uncomment this while you are testing your fifth method             *
            // **************************************************************************
            /*
            PrintLetters("rabbit");
            PrintLetters("Hello");
            PrintLetters("");
            PrintLetters("Halloween!");
            Console.WriteLine(".......................................................");
            */


            // **************************************************************************
            // Method #6 Testing                                                        *
            // TODO: Uncomment this while you are testing your sixth method             *
            // **************************************************************************
            /*
            double distance = Distance(0, 0, 0, 0);
            Console.WriteLine("The distance between (0, 0) and (0, 0) is: " + distance);

            distance = Distance(1, 0, 4, 4);
            Console.WriteLine("The distance between (1, 0) and (4, 4) is: " + distance);

            distance = Distance(10, 2, 3, 5);
            Console.WriteLine("The distance between (10, 2) and (3, 5) is: " + distance);
            Console.WriteLine(".......................................................");
            */

            #endregion
        }   // End of Main - All static methods must be written AFTER this


        #region Static Methods to Write

        // PUBLIC STATIC METHODS FOR STUDENTS TO WRITE:
        //
        // Public static methods should be written between the Main method
        //    and the end of Program class curly brace. 

        // **************************************************************************
        // TODO: Write method #1                                                    *
        //                                                                          *
        // Method #1: MakesTen                                                      *
        // Given 2 ints, return true if one if them is 10 or if their sum is 10.    *
        //                                                                          *
        // Method Identifier:   MakesTen                                            *
        // Parameters:          Receive 2 integers                                  *
        // Return:              A boolean                                           *
        //                                                                          *
        // Sample method calls and what they should return:                         *
        //   MakesTen(9, 10) → true                                                 *
        //   MakesTen(9, 9) → false                                                 *
        //   MakesTen(1, 9) → true                                                  *
        // **************************************************************************

        /*  W R I T E    T H E    M E T H O D    H E R E */

        // **************************************************************************
        // TODO: Write method #2                                                    *
        //                                                                          *
        // Method #2: Largest                                                       *
        // Given three int values, return the largest of the 3.                     *
        // If there is a "tie" for largest between 2 or 3 values, return either one.*
        //                                                                          *
        // Method Identifier:   Largest                                             *
        // Parameters:          Receive 3 integers                                  *
        // Return:              An integer representing the largest of the 3 values *
        //                                                                          *
        // Sample method calls and what they should return:                         *
        //   Largest(1, 2, 3) → 3                                                   *
        //   Largest(1, 3, 2) → 3                                                   *
        //   Largest(3, 2, 1) → 3                                                   *
        //   Largest(2, 1, 2) → 2                                                   *
        //   Largest(3, 3, 1) → 3                                                   *
        //   Largest(5, 5, 5) → 5                                                   *
        // **************************************************************************

        /*  W R I T E    T H E    M E T H O D    H E R E */

        // **************************************************************************
        // TODO: Write method #3                                                    *
        //                                                                          *
        // Method #3: NotString                                                     *
        // Given a string, return a new string where "not " is added to the front.  *
        // However, if the string already begins with "not", return the string      *
        //   unchanged.                                                             *
        //                                                                          *
        // Method Identifier:   NotString                                           *
        // Parameters:          Receive a string                                    *
        // Return:              String with "not " appended to the front            *
        //                                                                          *
        // Sample method calls and what they should return:                         *
        //   NotString("candy") → "not candy"                                       *
        //   NotString("x") → "not x"                                               *
        //   NotString("not bad") → "not bad"                                       *
        //   NotString("nothing") → "nothing"                                       *
        // **************************************************************************

        /*  W R I T E    T H E    M E T H O D    H E R E */

        // **************************************************************************
        // TODO: Write method #4                                                    *
        //                                                                          *
        // Method #4: RemoveIndex                                                   *
        // Given a non-empty string and an int n, return a new string where the     *
        //   character at index n has been removed.                                 *
        // The value of n must be a valid index of a char in the original string    *
        //   (i.e. n must be within the range 0 through Length-1 inclusive).        *
        // If the index is invalid, return the string "Index is out of range"       *
        //                                                                          *
        // Method Identifier:   RemoveIndex                                         *
        // Parameters:          Receive a string and an integer                     *
        // Return:              A string where a single character has been removed  *
        //                                                                          *
        // Sample method calls and what they should return:                         *
        //   RemoveIndex("kitten", 1) → "ktten"                                     *
        //   RemoveIndex("kitten", 0) → "itten"                                     *
        //   RemoveIndex("kitten", 5) → "kitte"                                     *
        //   RemoveIndex("kitten", 6) → "Index is out of range"                     *
        //   RemoveIndex("kitten", -1) → "Index is out of range"                    *
        // **************************************************************************

        /*  W R I T E    T H E    M E T H O D    H E R E */

        // **************************************************************************
        // TODO: Write method #5                                                    *
        //                                                                          *
        // Method #5: PrintLetters                                                  *
        // Accepts a string as its parameter.                                       *
        // Prints each letter of the string, separated by dashes, on a single line. *
        // Do not include a dash after the last letter.                             *
        //                                                                          *
        // Method Identifier:   PrintLetters                                        *
        // Parameters:          Receive a string                                    *
        // Return:              Nothing                                             *
        //                                                                          *
        // Sample method calls and what they should PRINT:                          *
        //   PrintLetters("rabbit") → r-a-b-b-i-t                                   *
        //   PrintLetters("hello") → h-e-l-l-o                                      *
        //   PrintLetters("") →  (nothing is printed)                               *
        //   PrintLetters("Halloween!") → H-a-l-l-o-w-e-e-n-!                       *
        // **************************************************************************

        /*  W R I T E    T H E    M E T H O D    H E R E */

        // **************************************************************************
        // TODO: Write method #6                                                    *
        //                                                                          *
        // Method #6: Distance                                                      *
        // Accepts 4 values (floating-point numbers are ok)                         *
        // Calculates the distance between (x1, y1) and (x2, y2)                    *
        //                                                                          *
        // Method Identifier:   Distance                                            *
        // Parameters:          Receive 4 integers                                  *
        // Return:              Double of the calculated distance between the 2     *
        //                      points in space.                                    *
        //                                                                          *
        // Sample method calls and what they should return:                         *
        //   Distance(0, 0, 0, 0) → 0                                               *
        //   Distance(1, 0, 4, 4) → 5                                               *
        //   Distance(10, 2, 3, 5) → 7.615773105863909                              *
        // **************************************************************************

        /*  W R I T E    T H E    M E T H O D    H E R E */




        #endregion

    }       // End of Program class - All static methods must be written BEFORE this
}           // End of Namespace