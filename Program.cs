using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
          
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double  S= Math.Pow(a, 2) + Math.Pow(b, 2);
            double P=2*a+2*b;

            Console.WriteLine("d= "+ d);
            Console.WriteLine("S= "+S);
            Console.WriteLine("P= "+P);
        }
    }
}
