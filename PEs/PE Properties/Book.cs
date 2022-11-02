using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_Properties
{
    internal class Book
    {
        //--------------------------
        // Fields
        //--------------------------

        private string title;
        private string author;
        private string owner;
        private int pages;
        private int timesRead;


        //--------------------------
        // Properties
        //--------------------------

        /// <summary>
        /// Read-only property for title
        /// </summary>
        public string Title
        {
            get
            {
                return title;
            }
        }

        /// <summary>
        /// Read-only property for author
        /// </summary>
        public string Author
        {
            get
            {
                return author;
            }
        }

        /// <summary>
        /// Read-only property for pages
        /// </summary>
        public int Pages
        {
            get
            {
                return pages;
            }
        }

        /// <summary>
        /// Get and Set property for owner
        /// </summary>
        public string Owner
        {
            get
            {
                return owner;
            }

            
            set
            {
                if (value.Length > 0)
                {
                    owner = value;
                }
            }
        }

        /// <summary>
        /// Returns timesRead and if timesRead is greater than what was already there
        /// change the value of timesRead and return it
        /// </summary>
        public int TimesRead
        {
            get
            {
                return timesRead;
            }

            set
            {
                if (timesRead > value)
                {
                    timesRead = value;
                }
            }
        }

        /// <summary>
        /// Read only property if book has been read, return true
        /// If not, return false
        /// </summary>
        public bool IsUsed
        {
            get
            {
                if (timesRead > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //--------------------------
        // Constructors
        //--------------------------

        /// <summary>
        /// Parameterized constructor for a new book object
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="owner"></param>
        /// <param name="pages"></param>
        public Book(string title,
            string author,
            string owner,
            int pages
            )
        {
            this.title = title;
            this.author = author;
            this.owner = owner;
            this.pages = pages;
            timesRead = 0;
        }

        //--------------------------
        // Methods
        //--------------------------

        /// <summary>
        /// Prints out all the information of the book
        /// </summary>
        void Print()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Pages: " + pages);
            Console.WriteLine("Owner: " + owner);
            Console.WriteLine("Times Read: " + timesRead);
            Console.WriteLine("Is Used: " + IsUsed);
        }

    }// End of class
}
