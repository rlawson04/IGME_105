
// Erin Cascioli
// 10/31/22
// Demo: Properties and Encapsulation

namespace Demo_PropertiesEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // With PRIVATE fields and using PROPERTIES, there is protection!
            // ----------------------------------------------------------------

            // Create an instance of Employee and print data
            EmployeePrivate bob = new EmployeePrivate("Bob", 75200);
            bob.Print();
            Console.WriteLine();

            // Use the get blocks of properties to retrieve private data
            string employeeName = bob.Name;
            double employeeSalary = bob.Salary;
            
            Console.WriteLine("{0}'s salary (per year) is {1:C2}. \n",
                employeeName,
                employeeSalary);

            // Change Bob's data with the Name property!
            // Uh oh. Can't do it. We didn't write a set block in the Name property.
            // Bob's name cannot be changed to anything other than the value at instantiation.
            //bob.Name = "Stinky McStinksalot";

            // Change Bob's salary with the Salary property!
            // The value 80000 would go inside the built-in variable "value" in the property
            bob.Salary = 80000;         // Will work!

            // Since the property limits this from happening, Bob's salary will not change to
            //   50 dollars per year.
            bob.Salary = 50;            // If statement in set is false. No change.    

            // Print data again
            bob.Print();
            Console.WriteLine();

            Console.WriteLine("Is Bob rich? " + bob.IsRich);

            Console.WriteLine("**********************************");


            // ----------------------------------------------------------------
            // With PUBLIC fields, no protection of data.
            // All data is accessible to classes outside of the class it's defined in
            // ----------------------------------------------------------------

            // Create an instance of Employee and print data
            EmployeePublic erin = new EmployeePublic("Erin", 5_000_000);
            erin.Print();
            Console.WriteLine();

            // Access public fields
            employeeName = erin.name;
            employeeSalary = erin.salary;
            Console.WriteLine("{0}'s salary (per year) is {1:C2}. \n",
                employeeName,
                employeeSalary);

            // Because I can access them - and they are public - I can change public fields, too.
            erin.name = "Goober";
            erin.salary = 1_000_000;

            // Print data again
            erin.Print();
            Console.WriteLine();

            Console.WriteLine("**********************************");
        }
    }
}