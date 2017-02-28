using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassImpressions
{
    class Interns
    {
        //private DateTime _Birthday;

        //public DateTime BirthDay
        //{
        //    get
        //    {
        //        return _Birthday;
        //    }
        //    set
        //    {
        //        _Birthday = value;
        //    }
        //}
        //     ||

        public DateTime BirthDay { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        private string _Sex;
        public string Sex
        {
            get
            {
                return _Sex;
            }
            set 
            {
                string lowerValue = value.Trim().ToLower();

                if (lowerValue == "male" || lowerValue == "female")
                {
                    _Sex = value.ToLower();
                }
                else if (lowerValue == "man" || lowerValue == "boy")
                {
                    _Sex = "male";
                }
                else if (lowerValue == "woman" || lowerValue == "girl")
                {
                    _Sex = "female";
                }
                else
                {
                    _Sex = "undefined";
                }
            }
        }

        //public Interns()
        //{

        //}

        public Interns(string firstName, string lastName, DateTime BirthDay, string sex)
        {
            this.BirthDay = BirthDay;
            FirstName = firstName;
            LastName = lastName;

            Sex = sex;
        }

        public void WriteToConsole()
        {
            Console.WriteLine("{0} {1} is a {3} intern born on {2:dd-MM-yyyy}", FirstName, LastName, BirthDay, Sex);
        }
    }
}
