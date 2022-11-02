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
    }
}
