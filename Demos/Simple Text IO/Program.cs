// Reilly Lawson
// 11/18/2022
// Testing IO

namespace Simple_Text_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader("../../../MyFile.txt");

                string lineOfText = " ";

                // Reads the file until null is found
                while (lineOfText != null)
                {
                    lineOfText = reader.ReadLine();

                    if (lineOfText == null)
                    {
                        break;
                    }
                    // Split data into an array of strings
                    string[] splitData = lineOfText.Split('|');
                    Console.WriteLine("Type of Monster: " + splitData[0]);
                    Console.WriteLine("Name of Monster: " + splitData[1]);
                    Console.WriteLine("Constitution: " + splitData[2]);
                }

                // Closes the file when done
                reader.Close();
            }
            catch (Exception error)
            { 
                Console.WriteLine(error.Message);
                Console.WriteLine(error.StackTrace);
            
            }



            try
            {
                // Open the file/Interact with it
                StreamWriter writer = new StreamWriter("../../../MyFile2.txt");

                writer.WriteLine("This line will appear on my file");
                writer.Write("This text ");
                writer.Write("will be ");
                writer.Write("next to each other");

                // When done with the file, close it
                writer.Close();
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine(error.StackTrace);
            }
        }
    }
}