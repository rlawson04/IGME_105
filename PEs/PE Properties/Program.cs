// Reilly Lawson
// 11/2/2022
// PE 18, using properties to gather user input 

using System.Runtime.InteropServices;

namespace PE_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables to be used throughout the program
            string userBook;
            string userAuthor;
            string userOwner;
            int userPages;
            string userInput = " ";
            string userInput2 = " ";

            // welcome message
            Console.WriteLine("Welcome to Book Simulator 2022!\n");

            // Prompt user for book title
            Console.Write("Enter the title of your book: ");
            userBook = Console.ReadLine().Trim();

            // Prompts user for the author of the book
            Console.Write("Enter the author of " + userBook + ": ");
            userAuthor = Console.ReadLine().Trim();

            //prompts user for the number of pages of the book and then tests the input
            Console.Write("Enter the number of pages in " + userBook + ": ");
            
            bool success = int.TryParse(Console.ReadLine(), out userPages);
           
            // Re prompts user to enter a valid input
            while (!success || userPages <= 0)
            {
                Console.Write("Please enter a positive integer number of pages: ");
                success = int.TryParse(Console.ReadLine(), out userPages);
            }
            
            // Prompts the user for the owner of the book
            Console.Write("Who currently owns " + userBook + "? ");
            userOwner = Console.ReadLine().Trim();

            // Create an instance of a book object using gathered data
            Book book= new Book(userBook, userAuthor, userOwner, userPages);

            // Prints the menu that the user can select from
            Console.WriteLine("\nYou may now type any of the following command:");
            Console.WriteLine("[title, author, pages, owner, read, used, print, quit]");

            // A while loop that keeps running until the user chooses quit for the user to interact with
            while (userInput != "QUIT")
            {
                Console.Write("\nWhat would you like to do? ");
                userInput = Console.ReadLine().ToUpper().Trim();

                // A switch with each case from the menu above
                switch (userInput)
                {
                    // Prints out the title of the book using book.Title property
                    case "TITLE":
                        Console.WriteLine("The books title is " + book.Title);
                        break;

                    // Prints out the author of the book using book.Author property
                    case "AUTHOR":
                        Console.WriteLine("The books author is " + book.Author);
                        break;

                    // Prints out the number of pages of the book using book.Pages property
                    case "PAGES":
                        Console.WriteLine("The books title has " + book.Pages);
                        break;

                    // Asks the user if they want to change the owner of the book
                    // Then changes the book.Owner property to the new owner
                    case "OWNER":
                        Console.Write("Would you like to change the owner? ");
                        userInput2 = Console.ReadLine().ToUpper().Trim();
                        if (userInput2 == "YES")
                        {
                            Console.Write("Who is the new owner?");
                            book.Owner = Console.ReadLine();

                            Console.WriteLine("The new owner is " + book.Owner);

                        }

                        if (userInput2 == "NO")
                        {
                            Console.WriteLine("The owner is " + book.Owner);
                        }

                        break;

                    // Changes the book.TimesRead property to add one and then prints
                    // how many times the book has been read
                    case "READ":
                        book.TimesRead++;
                        Console.WriteLine($"The book has been read {book.TimesRead} time(s)");
                        break;

                    // Checks the book.IsUsed property and determines if 
                    // the book has or has not been used
                    case "USED":
                        if (book.IsUsed == true)
                        {
                            Console.WriteLine("Yes, the book is used.");
                        }
                        else if (book.IsUsed == false)
                        {
                            Console.WriteLine("No, the book has not been used.");
                        }
                        break;

                    // Uses the Print method to print out all the information
                    case "PRINT":
                        book.Print();
                        break;

                    // Exits the while loop
                    case "QUIT":
                        break;

                    // Re-prompts the user if they typed something other than an option
                    default:
                        Console.WriteLine("Invalid option, Try again");
                        break;
                }
            }

            // Farewell statement
            Console.WriteLine("Thank you for using Book Simulator 2022!");

        } // End of main
    } // End of program
}