using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesClass
{
    class Boat : Vehicle
    {
       // public string MyProperty { get; set; }
        public Boat(string type, string mark, double speed, double power) : base("Boat", mark, speed, power)
        {

        }

        public override string Movement
        {
            get
            {
                return "See";
            }
        }
        public override string ToString()
        {
            return string.Format("{0} is a type of vehicle and moving on {1}.", TypeVihicle,Movement);
        }
    }
}
