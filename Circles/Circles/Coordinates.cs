using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles
{
    class Coordinates

    {
        public Coordinates(double x, double y, double r)
        {
            this.X = x;
            this.Y = y;
            this.R = r;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double R { get; set; }

    }
}
