using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConvertNumbers
{
    class NumberConversion
    {
        private object _Number;

        public NumberConversion(object Number)
        {            
            this.Number = Number;
        }

        public object Number
        {
            get
            {
                return _Number;
            }

            set
            {
                
                string partNumbers = Convert.ToString(value).Replace(" ", "");
                Regex rgx = new Regex("^([ivxlcdmIVXLCDM]+|[1-9]+)$");
                if (!rgx.IsMatch(partNumbers))
                {
                    this._Number = "You must enter a valid number!" + System.Environment.NewLine + "For arabic to roman conversion: 0-2500."
                        + System.Environment.NewLine + "For roman to arabic conversion: ivxlcdm(lower or uppercase.)";
                    //throw new  ArgumentOutOfRangeException("insert value betwheen 1 and 2500");
                }
                else
                {
                    int number1 = 0;
                    bool canConvert = int.TryParse(partNumbers, out number1);
                    if (canConvert)
                    {
                        this._Number = ConvertNumbersToRoman(number1);
                        //Console.WriteLine("Entered value is a number - " + _Number + " "  + _Number.GetType());                    
                    }
                    else
                    {
                        //StringBuilder roman = new StringBuilder(Convert.ToString(value));
                        string roman = partNumbers;
                        this._Number = Roman_Parse(roman.ToUpper());
                        //this._Number = value;
                        //Console.WriteLine("Entered value is a string - "  + _Number);
                    }
                }
            }
        }
        /// <summary>
        /// This method converts from arabic to roman numerals and vise versa.
        /// For arabic to roman conversion: 0-2500. For roman to arabic conversion: ivxlcdm (lower or uppercase.)
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string ConvertNumbersToRoman(int number)
        {
            if ((number < 0) || (number > 2500)) throw new ArgumentOutOfRangeException("Enter a value betwheen 1 and 2500.");
            if (number >= 1000) return "M" + ConvertNumbersToRoman(number - 1000);
            if (number >= 900) return "CM" + ConvertNumbersToRoman(number - 900);
            if (number >= 500) return "D" + ConvertNumbersToRoman(number - 500);
            if (number >= 400) return "CD" + ConvertNumbersToRoman(number - 400);
            if (number >= 100) return "C" + ConvertNumbersToRoman(number - 100);
            if (number >= 90) return "XC" + ConvertNumbersToRoman(number - 90);
            if (number >= 50) return "L" + ConvertNumbersToRoman(number - 50);
            if (number >= 40) return "XL" + ConvertNumbersToRoman(number - 40);
            if (number >= 10) return "X" + ConvertNumbersToRoman(number - 10);
            if (number >= 9) return "IX" + ConvertNumbersToRoman(number - 9);
            if (number >= 5) return "V" + ConvertNumbersToRoman(number - 5);
            if (number >= 4) return "IV" + ConvertNumbersToRoman(number - 4);
            if (number >= 1) return "I" + ConvertNumbersToRoman(number - 1);
            if (number < 1) return string.Empty;            
            throw new ArgumentOutOfRangeException("something bad happened");
        }
        public int Roman_Parse(String roman)
        {
            Dictionary<char, int> romanArabicDict = new Dictionary<char, int>();
            romanArabicDict.Add('I', 1);
            romanArabicDict.Add('V', 5);
            romanArabicDict.Add('X', 10);
            romanArabicDict.Add('L', 50);
            romanArabicDict.Add('C', 100);
            romanArabicDict.Add('M', 1000);
            
            int arabic = 0;

            for (int i = 0; i < roman.Count(); i++)
            {
                if (!romanArabicDict.ContainsKey(roman[i]))
                    return 0;

                if (i == roman.Count() - 1)
                {
                    arabic += romanArabicDict[roman[i]];
                }
                else
                {
                    if (romanArabicDict[roman[i + 1]] > romanArabicDict[roman[i]])
                    {
                        arabic -= romanArabicDict[roman[i]];
                    }
                    else
                    {
                        arabic += romanArabicDict[roman[i]];
                    }
                }
            }
            return arabic;
        }
    }
}
