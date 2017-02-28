using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassImpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime bDays = new DateTime(1999, 1, 5);
            Interns objectNiko = new Interns("Niko", "Ne pomnq", bDays, "boy");

            objectNiko.WriteToConsole();
        }
    }
}
