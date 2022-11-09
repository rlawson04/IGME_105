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

            // Inspect using properties
            Console.WriteLine("List count " + myList.Count);
            Console.WriteLine("List capacity " + myList.Capacity);

            // Adding values to the list
            myList.Add(3.14);

            // Inspect using properties
            Console.WriteLine("List count " + myList.Count);
            Console.WriteLine("List capacity " + myList.Capacity);

            myList.Add(7.27);

            // Inspect using properties
            Console.WriteLine("List count " + myList.Count);
            Console.WriteLine("List capacity " + myList.Capacity);
            
            myList.Add(2.0);

            // Inspect using properties
            Console.WriteLine("List count " + myList.Count);
            Console.WriteLine("List capacity " + myList.Capacity);

            myList.Add(1);

            // Inspect using properties
            Console.WriteLine("List count " + myList.Count);
            Console.WriteLine("List capacity " + myList.Capacity);

            myList.Add(2);

            // Inspect using properties
            Console.WriteLine("List count " + myList.Count);
            Console.WriteLine("List capacity " + myList.Capacity);

            myList.Add(3);

            // Inspect using properties
            Console.WriteLine("List count " + myList.Count);
            Console.WriteLine("List capacity " + myList.Capacity);

            myList[5] = 1.2345;

            // Inspect using properties
            Console.WriteLine("List count " + myList.Count);
            Console.WriteLine("List capacity " + myList.Capacity);

            // .Count is the list equivalent of .Length
            Console.WriteLine("The size of this list is " + myList.Count);

            myList2.Add("phone");
            
            // Foreach loop that prints the list
            foreach(double number in myList)
            {
                Console.WriteLine(number);
            }

            // For loop that prints the list
            for (int i = 0; i < myList.Count; i+=2)
            {
                Console.WriteLine(myList[i]);
                myList[i] = 999;
            }
        }
    }
}