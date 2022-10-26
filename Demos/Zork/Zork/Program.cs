//Reilly Lawson
//10/26/2022
//Personal Project (Zork game)

namespace Zork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = " ";
            string userPosition = "FIELD";
            string[] Inventory = new string[20];


            //Exit command for the whole game
            while (userInput != "EXIT GAME")
            {
                if (userPosition == "FIELD")
                {
                    Console.WriteLine("You wake up in a large field. Looking around you see a house in the distance." +
                        " In the other direction, you notice a long river. \n");

                    Console.Write(">");
                    userInput = Console.ReadLine().Trim().ToUpper();
                }

                while (userInput != "GO TO HOUSE" || userInput != "GO TO RIVER")
                {
                    switch (userInput)
                    {

                        case "GO TO HOUSE":

                            userPosition = "HOUSE";
                            break;

                        case "GO TO RIVER":

                            userPosition = "RIVER";
                            break;

                        default:

                            Console.WriteLine($"{userInput} isn't something I know \n");
                            Console.Write(">");
                            userInput = Console.ReadLine().Trim().ToUpper();
                            break;

                    }
                }

                while (userPosition == "HOUSE")
                {
                    Console.WriteLine("You aproach the house. The windows are barred with wooden planks" +
                                " and the door appears to be slightly open \n");
                    Console.Write(">");
                    userInput = Console.ReadLine().Trim().ToUpper();
                }

                while (userPosition == "RIVER")
                {
                    Console.WriteLine("You decide to go towards the river and see smoke rising up from the shore." +
                                " You see the remnants of a campfire that was hastily smothered. \n");
                    Console.Write(">");
                    userInput = Console.ReadLine().Trim().ToUpper();
                }
            }//End of Game section
        }//End of Main
    }//End of Program
}