using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionIntegerToRomanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var covertToRoman = new CovertIntToRoman(num);

           string covertValue= covertToRoman.CovertToRoman();
           
            Console.WriteLine(covertValue);


        }
    }
}
