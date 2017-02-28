using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_and_value_types_examples
{
    struct Coordinates
    {
        //These Fields should be private and used via properties. These are set this way for the example
        public double X, Y;

        public Coordinates(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
