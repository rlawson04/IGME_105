namespace Array_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create some literal arrays
            int[] numbers = { 2, 4, 6, 8, 10 };
            string[] words = { "Hi", "ok", "cool" };

            int[] numbers2 = new int[5];
            FillArray(numbers2, 74);

            string[] words2 = new string[3];
            FillArray(words2, "DATA");

            int[] myNewArray = ArrayOfMultiples(7, 5);
            int[] myNewArray2 = ArrayOfMultiples(3, 10);
            int[] myNewArray3 = ArrayOfMultiples(10, 5);

            Console.WriteLine();
        }//End of Main

        public static int SumOfElements(int[] array)
        {
            //Start with variable that accumulates values 
            //from the array. (it will be added to the method)
            int sum = 0;

            //itterate through each elelement, adding to the sum
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        //Void since it doesn't need to return anything 
        /// <summary>
        /// Fills an integer array with the same value over and over once called on an array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="startingValue"></param>
        public static void FillArray(int[] array, int startingValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = startingValue;
            }
        }
        
        /// <summary>
        /// Fills a string array with the starting value
        /// </summary>
        /// <param name="array"></param>
        /// <param name="startingValue"></param>
        public static void FillArray(string[] array, string startingValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = startingValue;
            }
        }

        /// <summary>
        /// Creates a new array that is factored by the first number 
        /// </summary>
        /// <param name="startingNumber"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int[] ArrayOfMultiples(int startingNumber, int length)
        {
            //Return a new array that has the starting number factored
            //for x length

            int[] factoredArray = new int[length];
            
            //Iterate for the number of elements
            for(int i = 0; i < length; i++)
            {
                //Assign a factor of startingNumber to the array
                factoredArray[i] = startingNumber * (i + 1);
            }

            return factoredArray;
        }
    }//End of Program
}