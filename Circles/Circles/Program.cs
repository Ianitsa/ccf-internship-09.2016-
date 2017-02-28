using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1, x2, y1, y2, r1, r2;
            double circlesDistance;

            Console.WriteLine("Enter the x1");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the x2");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y1");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y2");
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the r1");
            r1 = double.Parse(Console.ReadLine());
            if (r1<0)
            {
                Console.WriteLine("r1 must be > 0");
                r1 = double.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("Enter the r2");
            r2 = double.Parse(Console.ReadLine());
            if (r2 < 0)
            {
                Console.WriteLine("r2 must be > 0");
                r2 = double.Parse(Console.ReadLine());
            }

            var circle1 = new Coordinates(x1,y1,r1);
            var circle2 = new Coordinates(x2,y2,r2);

            double distance = Math.Sqrt(Math.Pow(circle2.X, 2) - Math.Pow(circle1.X, 2));
            circlesDistance= distance -(r2+r1);

            if (circlesDistance<0)
            {
                //??
                circlesDistance =Math.Abs( distance - (r2 -r1));
            }
            else if (circlesDistance==0)
            {
                circlesDistance = circle1.R - (distance + circle2.R);

            }
            Console.WriteLine("The distance between  the two circles is: {0}", circlesDistance);

        }
    }
}
