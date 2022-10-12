namespace Array.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // What can I put in an array?
            // health values
            // character names
            // tracking temperatures
            // boolean table if parking spots are open


            string[] phoneNumbers;
            phoneNumbers = new string[4];

            //string[] phoneNumbers = new string [4];
            phoneNumbers[0] = "802-349-4704";
            phoneNumbers[1] = "555-867-5309";
            phoneNumbers[2] = "999-999-9999";
            phoneNumbers[3] = "216-222-6798";
           
            PrintArray(phoneNumbers);

            phoneNumbers[1] = "666-185-1124";

            PrintArray(phoneNumbers);
            

            Console.WriteLine();

        }
        /// <summary>
        /// Prints the phone numbers in a fiven array
        /// </summary>
        /// <param name="phoneNums"></param>
        public static void PrintArray(string[] phoneNums)
        {
            for (int i = 0; i < phoneNums.Length; i++)
            {
                Console.WriteLine($"Index {i + 1}: " + phoneNums[i]);
            }
        }
    }
}