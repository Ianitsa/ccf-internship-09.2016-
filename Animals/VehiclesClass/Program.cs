using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat = new Boat("Boat", "Barum", 200, 2000);
            Car car = new Car("Cars", "Mercedes","Bogatti",300,2200,"petrol");
            Vehicle v = new Vehicle("Djeep", "JT", 210, 3000);
            string str = v.ToString();
            string newStr = boat.ToString();

            Console.WriteLine(car.Movement);
            Console.WriteLine(boat.Movement);
            Console.WriteLine(str);
            Console.WriteLine(newStr);

        }
    }
}
