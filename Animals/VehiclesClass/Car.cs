using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesClass
{
    class Car : Vehicle
    {
        public string Model { get; set; }
        public string Fuel { get;private set; }
        public Car(string type, string mark,string model, double speed, double power,string fuel) : base("Car", mark, speed, power)
        {
            this.Model = model;
            this.Fuel = fuel;
        }

        public override string Movement
        {
            get
            {
                return "Land";
            }
        }
        public override string ToString()
        {
            return string.Format("The {0} moving on {1}.", TypeVihicle, Movement);
        }
    }
}
