using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ring
{
    class CircleDistance
    {
        private double x1;
        private double x2;
        private double y1;
        private double y2;
        private double r1;
        private double r2;

       // public double distans=0;

        public CircleDistance(double x1,double y1,double r1,double x2,double y2,double r2  )
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.r1 = r1;
            this.r2 = r2;
                
        }

        public double X1
        {
            get {return this.x1; }
            set { this.x1=value; }
        }
        public double X2
        {
            get { return this.x2; }
            set { this.x2 = value; }
        }
        public double Y1
        {
            get { return this.y1; }
            set { this.y1 = value; }
        }
        public double Y2
        {
            get { return this.y2; }
            set { this.y2 = value; }
        }
        public double R1
        {
            get { return this.r1; }
            set { this.r1 = value; }
        }
        public double R2
        {
            get { return this.r2; }
            set { this.r2 = value; }
        }

        //public static double Distance(double x1, double y1, double r1, double x2, double y2, double r2)
        //{
        //   double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)) - (r2 + r1);
        //    return distance;
        //}

        public double Distance()
        {
            double distance = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)) - (R2 + R1);
            return distance;
        }



        // double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)) - (r2 + r1);

    }
}
