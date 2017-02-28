using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", "750", 2000, new DateTime(2007, 5, 1), 300, 2000, "gasoline");

            Console.WriteLine("{0} {1} - {6} has price {2} lv. It is {3} years. It has speed - {4}km/h  and it has {5} power", car.Brand, car.Model, car.Price, car.Age.Days / 365, car.Speed, car.Power, car.Fuel);
        }
    }
}
