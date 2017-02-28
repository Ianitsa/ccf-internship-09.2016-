using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ring
{
    class Circle
    {
        private double x;
        private double y;
        private double r;

        public Circle(double x, double y, double r)
        {
            this.x = x;    
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.Y; }
            set { this.y = value; }
        }
        public double R
        {
            get { return this.r; }
            set { this.r = value; }
        }

         


    }
}
