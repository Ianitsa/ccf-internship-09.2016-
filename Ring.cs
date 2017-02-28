using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ring
{
    class Ring
    {
        static void Main(string[] args)
        {








            string input;
            do
            {
                Console.WriteLine("Enter the x1");
                double x1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the x2");
                double x2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the y1");
                double y1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the y2");
                double y2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the r1");
                double r1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the r2");
                double r2 = double.Parse(Console.ReadLine());


                CircleDistance distance = new CircleDistance(x1, y1, r1, x2, y2, r2);

                //  double distance = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2))-(r2+r1);

                Console.WriteLine(distance.Distance());
                Console.WriteLine("Again?");
                input = Console.ReadLine();
            }
            while (input != "no");






            //new variant

            double x = 0;

            double y = 0;
            double r = 0;

            Circle circle1 = new Circle( x,  y,   r);
            Circle circle2 = new Circle(x, y, r);



            do
            {
                Console.WriteLine("Enter the x1");

                Console.WriteLine("Enter the y1");

                Console.WriteLine("Enter the r1");

                Console.WriteLine("Enter the x2");

                Console.WriteLine("Enter the y2");

                Console.WriteLine("Enter the r2");
                 




                Console.WriteLine("Again?");
                input = Console.ReadLine();

            } while (input != "no");









        }
    }
}
