using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingClasses.VehicleClasses
{
    class Vehicle
    {
        public virtual string VehicleType { get; set; }

        public virtual string Brand { get; set; }

        public Vehicle(string vehicleType)
        {
            this.VehicleType = vehicleType;
        }
    }
}
