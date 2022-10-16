using System.Diagnostics.CodeAnalysis;

namespace Gradebook_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            //Variables to be used throughout the program
            int numberOfAssignments = 0;
            string userIput = "";

            //Get number of assignments from user to help initialize the arrays
            Console.Write("How many assignments are you saving? ");
            userIput = Console.ReadLine().Trim();
            numberOfAssignments = int.Parse(userIput);

            //Check that user inputs a positive number, and re-prompts if it isn't  
            while (numberOfAssignments <= 0)
            {
                Console.Write("That is not a valid option. " +
                    "Enter the number of assignments: ");
                userIput = Console.ReadLine().Trim();
                numberOfAssignments = int.Parse(userIput);
            }

            //Tell user how many assignments are being saved.
            Console.WriteLine($"You are saving {numberOfAssignments} assignments.");

            Divider();

            //Arrays for the values and names of the exams
            string[] examNames = new string[numberOfAssignments];
            double[] examValues = new double[numberOfAssignments];

            //Get assignment name and grade from user based on how many assignments
            //they entered above
            for (int i = 0; i < numberOfAssignments; i++)
            {
                //Get name of each assignment and add it to the names array
                Console.Write($"Enter the name for assignment #{i + 1}: ");
                examNames[i] = Console.ReadLine().Trim();

                //Get the grade for each assignment and add it to the values array
                Console.Write($"Enter the grade for {examNames[i]}: ");
                userIput = Console.ReadLine().Trim();
                examValues[i] = double.Parse(userIput);

                //Check if the grade is less than 0 or greater than 100 and re-prompt
                while(examValues[i] < 0 || examValues[i] > 100)
                {
                    Console.Write("Grade must be between 0 and 100. Re-enter grade: ");
                    userIput = Console.ReadLine().Trim();
                    examValues[i] = double.Parse(userIput);
                }
                Console.WriteLine();
            }

            //Let the user know the arrays are full
            Console.WriteLine();
            Console.WriteLine("All grades are entered!");
            
            Divider();
            #endregion

            #region Part 2
            //Variable for average grade, sum of values divided by number of values
            double gradeAverage = SumOfArray(examValues)/numberOfAssignments;

            //Print out each exam name with its value as a "grade report"
            Console.WriteLine("Grade report:");
            for(int i = 0; i < numberOfAssignments; i++)
            {
                Console.WriteLine($"  {i+1}. {examNames[i]}: {examValues[i]}");
            }

            Divider();

            Console.WriteLine($"Average: {gradeAverage}");
            #endregion

            #region Part 3
            //Variable for assignment number they are replacing
            int assignmentNumber = 0;
            double newValue = 0;

            //Ask user for which assignment they want to change
            //add 1 to the index since people don't start at 0
            Console.WriteLine("Which number grade do you want to replace? ");
            userIput = Console.ReadLine().Trim();
            assignmentNumber = int.Parse(userIput);

            //Re prompt the user if their number is 0 or less, or if it is greater
            //than the number of assignments 
            while (assignmentNumber <= 0 || assignmentNumber > numberOfAssignments)
            {
                Console.WriteLine($"Index must be a number between " +
                    $"1 and {numberOfAssignments}. Try again");

                Console.Write("Which number grade do you want to replace? ");
                userIput = Console.ReadLine().Trim();
                assignmentNumber = int.Parse(userIput);
            }

            Console.WriteLine();

            //Ask the user for the new grade to input
            Console.Write($"What is the new grade for {examNames[assignmentNumber - 1]}? ");
            userIput = Console.ReadLine().Trim();
            newValue = double.Parse(userIput);

            //Again check that the value is between 0 and 100
            while (newValue < 0 || newValue > 100)
            {
                Console.Write("Grade must be between 0 and 100. Re-enter grade: ");
                userIput = Console.ReadLine().Trim();
                newValue = double.Parse(userIput);
            }

            //Tell user exactly which assingment is being replaced
            //as well as the new grade for it
            Console.WriteLine();
            Console.WriteLine($"Replacing the grade at index" +
                $" {assignmentNumber} with {newValue}\n");

            //Change element at the index,
            //altering from human counting to computer counting
            examValues[assignmentNumber - 1] = newValue;

            //Redo averages with new number
            gradeAverage = SumOfArray(examValues) / numberOfAssignments;

            //Reprint grade report with replaced value
            Console.WriteLine("Grade report:");
            for (int i = 0; i < numberOfAssignments; i++)
            {
                Console.WriteLine($"  {i + 1}. {examNames[i]}: {examValues[i]}");
            }

            Divider();

            Console.WriteLine($"Average: {gradeAverage}");
            #endregion

            #region Part 4




            #endregion
        }//End of Main

        /// <summary>
        /// Prints the name of all the elements of the string array
        /// </summary>
        /// <param name="nameArray"></param>
        public static void Print(string[] nameArray)
        {
            for(int i = 0; i < nameArray.Length; i++)
            {
                Console.WriteLine(nameArray[i]);
            }
            return;
        }

        /// <summary>
        /// Creates a nice visual divider
        /// </summary>
        public static void Divider()
        {
            Console.WriteLine("------------------------------------------------");
            
        }

        /// <summary>
        /// Gives the sum of all the values in the array
        /// </summary>
        /// <param name="valueArray"></param>
        /// <returns></returns>
        public static double SumOfArray(double[] valueArray)
        {
            double sum = 0;
            for (int i = 0; i < valueArray.Length; i++)
            { 
               sum += valueArray[i];
            }
            return sum;
        }

    }//End of Program
}