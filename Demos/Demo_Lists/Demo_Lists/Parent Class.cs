using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lists
{
    internal class Parent_Class
    {
        protected string word;
        protected int number;

        public string Word
        {
            get { return word; }    
        }

        public Parent_Class()
        {
            number = 10;
            word = "peanut";
        }
    }
}
