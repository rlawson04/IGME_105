using System;

namespace GDAPS1_FinalPractical
{
    class Program
    {

        /// <summary>
        /// An outline of Main() has been written for you with some test code and
        /// prompts for questions to answer
        /// 
        /// DO NOT MODIFY **except** where clearly marked with: 
        ///    - TODO: Enter your response in a comment here
        ///                 -or-
        ///    - TODO: UNCOMMENT the following
        /// </summary>
        static void Main(string[] args)
        {
            // Note: Yes, normally all variables used within the method should be declared
            // at the top of the method. This is not done in Main() to allow isolation of code
            // that won't compile until you complete each activity.

            /********************************************/
            /* ACTIVITY 1: Setup a basic inventory      */
            /********************************************/

            /**
             * Item ToString explanation
             *  - Using Weight in the Item class implementation of ToString
             *      results in the item's weight being included
             *      in the result of this method.
             *  - Why will this work even though the Item class doesn't implement 
             *      this property or have a "weight" field itself?
             *      
             *  NOTE: You do NOT need to write any code for this question. You are
             *  ONLY writing comments below to explain how ToString works in this
             *  scenario.
             */
            // TODO: Enter your response about Item ToString in a comment here
            // The item.ToString method is a public one which means all other classes
            // have access to it. Since the list inside inventory is of instances of 
            // items, you can call the method on the given instance or instances. If 
            // there was no instance of the object given, it would not work.


            // TODO: UNCOMMENT the following to test Activity 1
            Console.WriteLine("\n\n** Activity 1 **");
            Inventory myItems = new Inventory();
            myItems.AddItem(new Weapon("Sharp Stick", 5, 0.05));
            myItems.PrintSummary();


            /********************************************/
            /* ACTIVITY 2: Add support for foods        */
            /********************************************/

            // TODO: UNCOMMENT the following to test Activity 3
            Console.WriteLine("\n\n** Activity 2 **");
            Food testFood = new Food("Apple", 2, 0.25);
            testFood.Eat();
            testFood.Eat();
            testFood.Eat();
            myItems.AddItem(testFood);
            myItems.AddItem(new Food("Pumpkin Pie", 8, 0.1));
            myItems.AddItem(new Food("Cookies", 25, 0.03));
            myItems.PrintSummary();


            /********************************************/
            /* ACTIVITY 3: Load more items from a file  */
            /********************************************/

            // TODO: UNCOMMENT the following to test Activity 3
            Console.WriteLine("\n\n** Activity 3 **");
            myItems.LoadItems("../../../BAD.txt");
            myItems.LoadItems("../../../items.txt");
            myItems.LoadItems("../../../items.txt");
            myItems.PrintSummary();

            /********************************************/
            /* ACTIVITY 4: Lighten the load             */
            /********************************************/

            // TODO: UNCOMMENT the following to test Activity 4
            Console.WriteLine("\n\n** Activity 4 **");
            myItems.LightenLoad();
            myItems.PrintSummary();

        }

    }
}
