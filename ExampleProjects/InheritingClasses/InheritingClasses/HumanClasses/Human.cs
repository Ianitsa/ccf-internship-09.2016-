using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingClasses
{
    class Human
    {
        public int height;

        public string HairColor { get; set; }

        public double Height { get; set; }

        protected DateTime BirthDay { get; set; }

        public virtual TimeSpan Age
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

        public void TellAJoke()
        {
            Console.WriteLine("{0} tells a joke, everybody laughs. :D", this.Name);
        }

        public virtual void DisplayBirthCertificate()
        {
            Console.WriteLine("Name: {0}\nGender: {1}\nBirthday: {2:dd/MMM/yyyy}", this.Name, this.Gender, this.BirthDay);
        }
    }
}
