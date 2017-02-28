using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human Ivan = new Human("Ivan", new DateTime(1992, 12, 12), "male");

            Human Ivan = new Blonde("Ivan", new DateTime(1992, 12, 12), "male");
            Human Petkan = new Human("Petkan", new DateTime(1992, 12, 12), "female");

            Ivan.DisplayBirthCertificate();
            Petkan.DisplayBirthCertificate();

            Console.WriteLine(Ivan.Age.TotalDays / 365);
            Console.WriteLine(Petkan.Age.TotalDays / 365);
            //(Ivan as Blonde).TellAJoke();
        }
    }
}
