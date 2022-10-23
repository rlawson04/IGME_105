namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4,3,8,5,1,2 };
            ArrayMystery2(numbers);
            Console.WriteLine();
        }
        public static void ArrayMystery2(int[] data)
        {
            for (int i = 1; i < data.Length - 1; i++)
            {
                if (data[i] == data[i - 1] + data[i + 1])
                {
                    data[i] = data[i] / 2;
                }
            }
        }
    }
}