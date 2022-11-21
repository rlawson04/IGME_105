namespace Demo_TextFileIO_DoubleReadline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader("../../../Monsters.txt");

                // Read in all lines of text from the file
                string lineOfText = "";

                while((lineOfText = reader.ReadLine()) != null)
                {
                    Console.WriteLine(lineOfText);

                    // Do something meaningful with the data!
                    string[] splitData = lineOfText.Split('|');
                    // What can we do here?  How do we know if its a Monster, Zombie or Vampire?
                    // How can we use that data to instantiate an appropriate object?
                    
                if (splitData[0] == "Monster")
                    {
                        Monster guy = new Monster
                            (splitData[1],              // Name
                            int.Parse(splitData[2]),    // Age
                            int.Parse(splitData[3]));   // Const
                    }
                }

                /*
                while (lineOfText != null)
                {
                    // With the ReadLine inside the body of this while loop, 
                    //   we must check for null.
                    // Null is returned when the stream runs out of data to read.
                    lineOfText = reader.ReadLine();

                    // Ensure that the stream returned actual data from the file...
                    if (lineOfText != null)
                    {
                        Console.WriteLine(lineOfText);

                        // Do something meaningful with the data!
                        //string[] splitData = lineOfText.Split('|');
                        // What can we do here?  How do we know if its a Monster, Zombie or Vampire?
                        // How can we use that data to instantiate an appropriate object?
                    }
                }
                */

                // Close the stream
                reader.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine("File read error: " + error.Message);
            }
        }
    }
}