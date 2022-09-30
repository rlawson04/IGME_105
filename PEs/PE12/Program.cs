//Reilly Lawson
//9/28/2022
//Loops and GitHub practice exercise
namespace PE12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int loopCounter = 20;
            Divider();
            while (loopCounter < 24)
            {
                Console.WriteLine(loopCounter);
                loopCounter++; 
            }
            Divider();

            loopCounter = 20;
            while (loopCounter < 24)
            {
                Console.Write(loopCounter + " ");
                loopCounter = loopCounter + 1;
            }
            Divider();
        }
        
        /// <summary>
        /// Creates a visual barrier between lines of code
        /// </summary>
        public static void Divider ()
        {
            
            Console.WriteLine("======================================");
        }
    }
}