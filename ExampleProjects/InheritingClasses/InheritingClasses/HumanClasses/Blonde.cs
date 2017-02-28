using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingClasses
{
    class Blonde : Human
    {
        public override TimeSpan Age
        {
            get
            {
                return (DateTime.Now - BirthDay) - new TimeSpan(24, 0, 0);
            }
        }

        public Blonde(string name, DateTime birthDay, string gender) : base(name, birthDay, gender)
        {
            this.HairColor = "blond";
        }

        public new void TellAJoke()
        {
            Console.WriteLine("{0} tells a joke, please laugh. :(", this.Name);
        }

        public override void DisplayBirthCertificate()
        {
            Console.WriteLine("Blonde Name: {0}\nBlonde Gender: {1}\nBlonde Birthday: {2:dd/MMM/yyyy}", this.Name, this.Gender, this.BirthDay);
        }
    }
}
