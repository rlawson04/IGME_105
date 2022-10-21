namespace Random_TryParse_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Try Parse
            Console.WriteLine("Enter a double: ");
            double result;
            bool success = double.TryParse(Console.ReadLine(), out result);

            Console.WriteLine("Result is " + result);
            Console.WriteLine("Success is " + success);

            while(!success)
            {
                //reprompt
                Console.WriteLine("Enter a double: ");
                success = double.TryParse(Console.ReadLine(), out result);
                Console.WriteLine("Result is " + result);
                Console.WriteLine("Success is " + success);
            }

        }
    }
}