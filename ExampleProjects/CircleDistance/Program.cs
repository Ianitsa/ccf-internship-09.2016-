using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle firstCircle, secondCircle;
            bool carryOn = true;

            while (carryOn)
            {
                firstCircle = GenerateCircle("first");

                secondCircle = GenerateCircle("second");

                Console.WriteLine("Result:");
                Console.WriteLine(CalculateDistance(firstCircle, secondCircle));

                Console.WriteLine("Would you like to try again ? [y/n]");
                carryOn = Console.ReadLine().Trim().ToLower() == "y";
            }

            Console.WriteLine("Goodbye my only friend ;( ...");
            System.Threading.Thread.Sleep(2000);
        }

        static Circle GenerateCircle(string circleNumber)
        {
            double x, y, r;
            do
            {
                Console.WriteLine("Enter a value for the " + circleNumber + " circle's X");
            }
            while (!double.TryParse(Console.ReadLine(), out x));

            do
            {
                Console.WriteLine("Enter a value for the " + circleNumber + " circle's Y");
            }
            while (!double.TryParse(Console.ReadLine(), out y));

            do
            {
                Console.WriteLine("Enter a value for the " + circleNumber + " circle's R");
            }
            while (!double.TryParse(Console.ReadLine(), out r) || r <= 0);

            return new Circle(x, y, r);
        }

        static double CalculateDistance(Circle first, Circle second)
        {
            double centreDistance = Math.Sqrt(Math.Pow(first.X - second.X, 2) + Math.Pow(first.Y - second.Y, 2));

            if (centreDistance > first.R + second.R)
            {
                return centreDistance - (first.R + second.R);
            }
            else if (centreDistance < Math.Abs(first.R - second.R))
            {
                return first.R > second.R ?
                    (first.R - (centreDistance + second.R)) :
                    (second.R - (centreDistance + first.R));
            }
            else if (centreDistance == first.R + second.R || centreDistance == Math.Abs(first.R - second.R))
            {
                Console.WriteLine("Touching");
            }
            else
            {
                Console.WriteLine("Intersecting");
            }

            return 0.0;
        }
    }
}
