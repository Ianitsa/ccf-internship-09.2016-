using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            NumberConversion arabic = new NumberConversion(userInput);
            Console.WriteLine(arabic.Number);
            Console.ReadLine();
        }
    }
}
