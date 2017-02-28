using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryDataTypesAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            CastingAndFloatingDecimalPointExamples();

            Console.ReadLine();
        }

        static void BooleanOperators()
        {
            bool a = true,
                b = true;

            Console.WriteLine("a\tb\ta || b\ta && b");
            Console.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}", a, b, a || b, a && b));

            a = true;
            b = false;
            Console.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}", a, b, a || b, a && b));

            a = false;
            b = true;
            Console.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}", a, b, a || b, a && b));

            a = false;
            b = false;
            Console.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}", a, b, a || b, a && b));

            a = true;
            b = false;

            bool c = (a || !b) ^ b;
            Console.WriteLine("c = (a || b) && b;\n" + c);
        }

        static void ArithmeticOperators()
        {
            int a = 5;

            int b = 7;

            Console.WriteLine("a\tb\ta+b\ta-b\ta*b\ta/b\ta%b");
            Console.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", a, b, a + b, a - b, a * b, a / b, a % b));

            a = a + 6;
            b = a - b;

            Console.WriteLine("\na = a + 6;\nb = a - b;\n");
            Console.WriteLine("a\tb\ta+b\ta-b\ta*b\ta/b\ta%b");
            Console.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", a, b, a + b, a - b, a * b, a / b, a % b));

            a++;
            b--;

            Console.WriteLine("\na++;\nb--;\n");
            Console.WriteLine("a\tb\ta+b\ta-b\ta*b\ta/b\ta%b");
            Console.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", a, b, a + b, a - b, a * b, a / b, a % b));

            //a+=b;
            a += ++b;
            Console.WriteLine("\na += ++b;");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);


            a = a * a + (-b) / 42;
            Console.WriteLine("\na = a + a * b;");
            Console.WriteLine("a = " + a);

            bool equality = a / 4 * 16 == b;

            Console.WriteLine("equality = " + equality);
        }

        static void InlineConditionOperator()
        {
            int a = 5;

            int b = ((a % 2 != 0) ? a : a * 2) * 3;
            b = a % 2 == 0 ? a++ : a * 3;
            Console.WriteLine("\nb=" + b);
            Console.WriteLine("a=" + a);

            b = (a % 2 == 0 ? a : b) + 1;
            
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);

            a = 5;
            Console.WriteLine("\nb=" + b);
            Console.WriteLine("a=" + a);
        }

        static void CastingAndFloatingDecimalPointExamples()
        {
            int integerObject = 5;
            double standartCastObject = integerObject + 0.999999;

            integerObject = (int)standartCastObject;
            Console.WriteLine("double = " + integerObject);
            //referenceCastObject = integerObject as double; - Only works with reference type and nullable objects

            float smallestFloatType = 22f;
            double balancedFloatType = 22;
            decimal mostPresiceFloatType = 22m;

            int a = 1;
            int b = 3;

            smallestFloatType /= b;

            Console.WriteLine(smallestFloatType);

            balancedFloatType /= b;

            Console.WriteLine(balancedFloatType);

            mostPresiceFloatType /= b;

            Console.WriteLine(mostPresiceFloatType);
        }
    }
}
