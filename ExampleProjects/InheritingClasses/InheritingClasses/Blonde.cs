using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingClasses
{
    class Blonde : Human
    {
        public Blonde(string name, DateTime birthDay, string gender) : base(name, birthDay, gender)
        {
            this.HairColor = "blond";
        }

        public void TellAJoke()
        {
            Console.WriteLine("{0} tells a joke, please laugh. :(", this.Name);
        }

        public void DisplayBirthCertificate()
        {
            Console.WriteLine("Name: {0}\nGender: {1}\nBirthday: {2:dd/MMM/yyyy}", this.Name, this.Gender, this.BirthDay);
        }
    }
}
