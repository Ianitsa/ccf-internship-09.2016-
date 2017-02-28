using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberProblem
{
    class Convert
    {
        private int input;
        public int Input
        {
            get
            {
                return input;
            }
            set
            {
                int tempInputNumber = value;
                if(tempInputNumber > 0 && tempInputNumber < 2000)
                    input = value;
                else
                    Console.WriteLine("Invalid number. ");
            }
        }

        private string output;
        public string Output
        {
            get
            {
                return output;
            }
            private set
            {
                output = value;
            }
        }
        public void ConvertToRoman()
        {
            StringBuilder romanNumber = new StringBuilder();
            while (input >= 1)
            {
                if (input >= 1000)
                {
                    romanNumber.Append("M");
                    input -= 1000;
                }
                else if (input >= 900)
                {
                    romanNumber.Append("CM");
                    input -= 900;
                }
                else if (input >= 500)
                {
                    romanNumber.Append("D");
                    input -= 500;
                }
                else if (input >= 400)
                {
                    romanNumber.Append("CD");
                    input -= 400;
                }
                else if (input >= 100)
                {
                    romanNumber.Append("C");
                    input -= 100;
                }
                else if (input >= 90)
                {
                    romanNumber.Append("XC");
                    input -= 90;
                }
                else if (input >= 50)
                {
                    romanNumber.Append("L");
                    input -= 50;
                }
                else if (input >= 40)
                {
                    romanNumber.Append("XL");
                    input -= 40;
                }
                else if (input >= 10)
                {
                    romanNumber.Append("X");
                    input -= 10;
                }
                else if (input >= 9)
                {
                    romanNumber.Append("IX");
                    input -= 9;
                }
                else if (input >= 5)
                {
                    romanNumber.Append("V");
                    input -= 5;
                }
                else if (input >= 4)
                {
                    romanNumber.Append("IV");
                    input -= 4;
                }
                else if (input >= 1)
                {
                    romanNumber.Append("I");
                    input -= 1;
                }
            }
            Output = romanNumber.ToString();
        }

        public int ConvertToArabic(string input)
        {
            char[] roman = input.ToUpper().ToArray();
            Dictionary<char, short> lookup = new Dictionary<char, short>();
            lookup.Add('M', 1000);
            lookup.Add('D', 500);
            lookup.Add('C', 100);
            lookup.Add('L', 50);
            lookup.Add('X', 10);
            lookup.Add('V', 5);
            lookup.Add('I', 1);

            int arabic = 0;

            for (int i = 0; i < roman.Count(); i++)
            {
                if (i == roman.Count() - 1)
                {
                    arabic += lookup[roman[i]];
                }
                else
                {
                    if (lookup[roman[i + 1]] > lookup[roman[i]]) arabic -= lookup[roman[i]];
                    else arabic += lookup[roman[i]];
                }
            }
            return arabic;
        }
    }
}
