using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingClasses.VehicleClasses
{
    class Porsche : Car
    {
        //public override string VehicleType
        //{
        //    get
        //    {
        //        return "Sports Car";
        //    }
        //}

        //public override string Brand
        //{
        //    get
        //    {
        //        return "Porsche";
        //    }
        //}

        public Porsche()
            : base("Porsche")
        {
        }
    }
}
