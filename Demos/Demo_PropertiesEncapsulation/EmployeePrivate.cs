using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PropertiesEncapsulation
{
    // EmployeePrivate class uses private fields with properties to access the data.
    // This controls access to data and can place limitations on access/changes.

    internal class EmployeePrivate
    {
        // --------------------------------------------------------------------
        // Fields are listed first
        // --------------------------------------------------------------------
        private string name;
        private double salary;

        // --------------------------------------------------------------------
        // Properties are listed next
        // --------------------------------------------------------------------

        /// <summary>
        /// Returns the name of this employee.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Get and Set for salary.
        /// Set can only receive values that are larger than the current salary 
        /// but less than 100000.
        /// </summary>
        public double Salary
        {
            // Regular old get
            get
            {
                return salary;
            }

            // Limits the incoming "value" when assigning to the salary field.
            set
            {
                if (value > salary && value < 100000)
                {
                    this.salary = value;
                }
            }
        }

        /// <summary>
        /// Property without a backing field.
        /// Determines whether an employee is rich depending on income limits.
        /// </summary>
        public bool IsRich
        {
            get
            {
                // An employee is considered "rich" if they make more than 300,000 per year.
                if (salary > 300000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        // --------------------------------------------------------------------
        // Constructor comes after properties
        // --------------------------------------------------------------------
        public EmployeePrivate(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        // --------------------------------------------------------------------
        // Methods are written last and should have a comment block above each one, like so:
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


        // These are examples of how we COULD access the data inside private fields to
        //    access or modify them by using methods.
        // FYI: THIS IS NOT HOW ITS CODED IN C#.
        //      C# USES DIFFERENT SYNTAX.
        //      DO NOT DO THIS.
        //public string GetName()
        //{
        //    return name;
        //}
        //
        //public double GetSalary()
        //{
        //    return salary;
        //}
        //
        //public void SetSalary(double value)
        //{
        //    if (value > salary && value < 100000)
        //    {
        //        this.salary = value;
        //    }
        //}
    }
}
