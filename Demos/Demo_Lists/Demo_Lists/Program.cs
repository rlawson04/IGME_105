namespace Demo_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initializing new Lists
            List<double> myList = new List<double>();
            List<string> myList2 = new List<string>();
            List<bool> myList3 = new List<bool>();

            // Adding values to the list
            myList.Add(3.14);
            myList.Add(7.27);
            myList.Add(2.0);
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);  

            myList[5] = 1.2345;

            // .Count is the list equivalent of .Length
            Console.WriteLine("The size of this list is " + myList.Count);

            myList2.Add("phone");
        }
    }
}