using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingClasses.VehicleClasses
{
    class Car : Vehicle
    {
        //public override string VehicleType
        //{
        //    get
        //    {
        //        return "Car";
        //    }
        //}

        public Car()
            : base("Car")
        {

        }

        public Car(string brand)
            : base("Car")
        {
            this.Brand = brand;
        }
    }
}
