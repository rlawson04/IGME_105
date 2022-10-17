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
        }
    }
}