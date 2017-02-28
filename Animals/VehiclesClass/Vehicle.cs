using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesClass
{
    class Vehicle
    {
        public string TypeVihicle { get; set; }
        public string Mark { get; set; }
        public double Speed { get; set; }
        public double Power { get; set; }
        public virtual string Movement
        {
            get
            {
                return "Something else..";
            }
        }
        public Vehicle(string type, string mark, double speed, double power)
        {
            this.TypeVihicle = type;
            this.Mark = mark;
            this.Speed = speed;
            this.Power = power;  
        }

        public override string ToString()
        {
            return  string.Format("{0} is a type of vehicle.",TypeVihicle);
        }

    }
}
