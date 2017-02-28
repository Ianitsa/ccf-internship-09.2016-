using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingClasses
{
    class Human
    {
        public string HairColor { get; set; }

        public double Height { get; set; }

        private DateTime BirthDay { get; set; }

        private TimeSpan Age
        {
            get
            {
                return DateTime.Now - BirthDay;
            }
        }

        protected string Name { get; set; }

        public string Gender { get; set; }

        private double Weight { get; set; }

        private int IQ { get; set; }

        public Human()
        {

        }

        public Human(string name, DateTime birthDay, string gender)
        {
            this.Name = name;
            this.BirthDay = birthDay;
            this.Gender = gender;
        }

        public void DisplayBirthCertificate()
        {
            Console.WriteLine("Name: {0}\nGender: {1}\nBirthday: {2:dd/MMM/yyyy}", this.Name, this.Gender, this.BirthDay);
        }
    }
}
