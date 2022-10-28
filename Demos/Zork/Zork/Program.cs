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
            string userPosition = " ";
            string[] Inventory = new string[20];

            Console.WriteLine("You wake up in a large field. Looking around you see a house in the distance." +
                        " In the other direction, you notice a long river. \n");
            Console.Write("> ");
            userInput = Console.ReadLine().Trim().ToUpper();
            //Exit command for the whole game
            while (userInput != "EXIT GAME")
            {

                if (userInput == "GO TO HOUSE")
                {
                    userPosition = "HOUSE";
                    userInput = " ";
                }

                while (userPosition == "HOUSE")
                {
                    Console.WriteLine("You aproach the house. The windows are barred with wooden planks" +
                                " and the door appears to be slightly open \n");
                    Console.Write("> ");
                    userInput = Console.ReadLine().Trim().ToUpper();

                    if (userInput == "GO BACK")
                    {
                        userPosition = "FIELD";
                    }

                    if (userInput == "GO INSIDE")
                    {
                        userPosition = "INSIDE HOUSE";
                    }
                }

                while (userPosition == "INSIDE HOUSE")
                {
                    Console.WriteLine("You push open the door. It lets out a slow creaking " +
                        "noise as you enter. A musty smell fills your nostrils as you take in your surroundings" +
                        "You look around and see a tattered rug sprawled out " +
                        "across broken floorboards filled with splintered and rotted wood.");
                    Console.WriteLine("You notice a stair case along the side of the wall that looks inoperable." +
                        "You can't make at much else inside the house due to the windows being barred by thick wooden planks.");
                }

                if (userInput == "GO TO RIVER")
                {
                    userPosition = "RIVER";
                }

                if (userPosition == "RIVER")
                {
                    Console.WriteLine("You decide to go towards the river and see smoke rising up from the shore." +
                                " You see the remnants of a campfire that was hastily smothered. \n");
                    Console.Write("> ");
                    userInput = Console.ReadLine().Trim().ToUpper();
                }


            }//End of Game section
        }//End of Main
    }//End of Program
}