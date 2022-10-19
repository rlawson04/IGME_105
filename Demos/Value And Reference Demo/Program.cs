namespace Value_And_Reference_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Two arrays with values
            //a is a reference for b
            int[] a = { 5, 10, 15 };
            int[] b = a;

            //Changing a element 0 also changes b element 0
            a[0] = 2000;

            //Value types
            int c = 5;
            int d = c;
            c = 200;
            //Value c becomes 200 but d stays as 5
            //since it makes a copy at a certain point (where c == 5)
            //even though the original changes, the copy doesn't


            Console.WriteLine("Start");
            //Create 100,000,000 new arrays
            for (int i = 0; i < 100_000_000; i++)
            {
                // Declare and initialize a new array, size 2, of ints
                int[] newArray = new int[2];

                // Insert data of 1 and 2 at index 0 and 1
                newArray[0] = 1;
                newArray[1] = 2;
            }
            Console.WriteLine("End");
        }
    }
}