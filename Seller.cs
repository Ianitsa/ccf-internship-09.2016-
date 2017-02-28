using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saler
{
    class Seller
    {
        private string _Name;
        //private DateTime _BirthDate;

        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(this._Name))
                {
                    this._Name = value;
                }
                else
                {
                    throw new ArgumentNullException("Cannot Rename an Employee!");
                }
            }
        }

        public DateTime BirthDate { get; private set; }
        public TimeSpan Age
        {
            get { return DateTime.Now - BirthDate; }
        }
        public string Position { get; set; }
        private decimal Salary { get; set; }
        public string Productivity { get; set; }

        public Seller(string name, DateTime BirthDate, decimal salary, string position, string productivity)
        {
            this.BirthDate = BirthDate;
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Productivity = productivity;
        }

        int status = 0;
        public void Satisfaction()
        {

            if (Salary < 500)
            {
                Console.WriteLine("The {0} is not satisfaction.", Name);
                status = -1;
            }
            else if (Salary >= 600)
            {
                Console.WriteLine("The {0} is satisfaction.", Name);
                status = 1;
            }
            else
            {
                Console.WriteLine("The {0} is satisfaction sometimes.", Name);
                status = 0;
            }
        }


        public void CangeSalary()
        {
            if (Productivity == "good")
            {
                if (status == -1)
                {
                    Console.WriteLine("Bad luck!");
                }
                if (status == 0)
                {
                    Console.WriteLine("Good luck!");
                } 
                if (status == 1)
                {
                    Console.WriteLine("Better luck!");
                }
            }
            else if (Productivity == "bad")
            {
                if (status == -1)
                {
                    Console.WriteLine("You must be dismissal.");
                }
                else if (status == 0)
                {
                    Console.WriteLine("You must be downgraded");
                }
                if (status == 1)
                {
                    Console.WriteLine("You must be upgraded");
                }
            }
            else if (Productivity == "best")
            {
                if (status == -1)
                {
                    Console.WriteLine("kartofite sa se wkisnali");
                }
                else if (status == 0)
                {
                    Console.WriteLine("staa");
                }
                if (status == 1)
                {
                    Console.WriteLine("You must be raised.");
                }
            }
            else
            {
                Console.WriteLine("Invalid productivity name!");
            }
        }

    }
}
