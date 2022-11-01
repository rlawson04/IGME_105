using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PropertiesEncapsulation
{
    // EmployeePublic class uses public fields.
    // All data in this class can be accessed/manipulated outside of this class.

    internal class EmployeePublic
    {
        // --------------------------------------------------------------------
        // Public fields allow outside classes to manipulate their data
        // --------------------------------------------------------------------
        public string name;
        public double salary;

        // --------------------------------------------------------------------
        // Constructors should generally be public.
        // Why?
        // Because outside classes need to be able to initialize objects of this class.
        // A private constructor would not be visible to Main, or any other class
        //   needing to create an Employee object. 
        // --------------------------------------------------------------------
        public EmployeePublic(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        // --------------------------------------------------------------------
        // Methods can be either public or private.  Usually public.
        // Why?
        // Because outside classes need to be able to call methods of this class.
        // A private method is not be visible to any outside class.
        // Will we ever have private methods?  Sure!
        //   But we'll write them in specific ways (and utilize the private keyword
        //   for protection of the class.)
        // --------------------------------------------------------------------

        /// <summary>
        /// Prints information about this employee
        /// </summary>
        public void Print()
        {
            Console.WriteLine("{0} makes {1:C2} per year.",
                name,
                salary);
        }
    }
}
