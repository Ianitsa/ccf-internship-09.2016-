using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow_Control_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            BreakAndContinueFunctionality();

            Console.ReadLine();
        }

        static void DisplayNumbersFrom1To10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            int counter = 0;

            while (counter <= 10)
            {

                Console.WriteLine(counter);
                counter++;

            }
        }

        static void Difference_Between_While_And_DoWhile()
        {
            int p = 8;

            while (p < 10)
            {
                Console.WriteLine("This came from a \"while\" loop.");
                p++;
            }

            do
            {
                Console.WriteLine("This came from a \"do-while\" loop.");
                p++;
            }
            while (p < 10);
        }

        static void Go_Through_A_Collection()
        {
            int[] arrayFromInts = new int[25];

            //assign values to the array elements
            for (int i = 0; i < 25; i++)
            {
                arrayFromInts[i] = 25 - i;
            }

            //write all elements in the console
            foreach (int element in arrayFromInts)
            {
                Console.WriteLine(element);
            }

            int index = 0;

            //write all elements dividable by 3 in the console
            while (index < 25)
            {
                if (arrayFromInts[index] % 3 == 0)
                    Console.WriteLine(arrayFromInts[index]);
                index++;
            }
        }

        static void SwitchCase_And_CaseFallThrough()
        {
            string input = Console.ReadLine().ToLower();

            //Go through the string as if it's an array of 'char' elements.
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                        Console.WriteLine("This is an 'a'");
                        break;
                    case 'b':
                    case 'c':
                    case 'd':
                        Console.WriteLine("Either a 'b', 'c' or a 'd'.");
                        break;
                    case '%':
                        Console.Write("This is a ... ");
                        goto default;
                    case '$':
                        Console.WriteLine("Money ?!? $$$");
                        break;
                    //We can't just fall through to another case when there is already logic in the one falling through from.
                    default:
                        Console.WriteLine("Who knows what char this is?!?");
                        break;
                }
            }
        }

        static void BreakAndContinueFunctionality()
        {
            int[] arrayOfInts = new int[25];

            //assign values to the array elements
            for (int i = 0; i < 25; i++)
            {
                arrayOfInts[i] = 25 - i;
            }

            foreach (int element in arrayOfInts)
            {
                if ((element & 1) == 0) //Check if element is an even number and skip it if so.
                    continue;

                Console.WriteLine(element);
            }

            Random rnd = new Random();
            arrayOfInts = arrayOfInts.OrderBy(x => rnd.Next()).ToArray();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < arrayOfInts.Length; j++)
                {
                    if (arrayOfInts[j] == 3)
                    {
                        Console.WriteLine("3!");
                        break;
                    }
                    Console.Write(arrayOfInts[j] + ", ");
                }

                Console.WriteLine("Shuffling!");
                arrayOfInts = arrayOfInts.OrderBy(x => rnd.Next()).ToArray();
            }
        }
    }
}
