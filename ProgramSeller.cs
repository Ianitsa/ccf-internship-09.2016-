using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saler
{
    class ProgramSeller
    {
        static void Main(string[] args)
        {
            Seller seller1 = new Seller("Ani", new DateTime(1980, 07, 09), 450, "Casher", "bad");
            Console.WriteLine("{0} is {1} years old, work as {2}", seller1.Name, seller1.Age.Days / 365, seller1.Position);
            seller1.Satisfaction();
            seller1.CangeSalary();

            Seller seller = new Seller("Ani", new DateTime(1980, 07, 09), 450, "Casher", "best");
            Console.WriteLine( "{0} is {1} years old, work as {2}", seller.Name , seller.Age.Days/365 , seller.Position);
            seller.Satisfaction();
            seller.CangeSalary();
        }
    }
}
