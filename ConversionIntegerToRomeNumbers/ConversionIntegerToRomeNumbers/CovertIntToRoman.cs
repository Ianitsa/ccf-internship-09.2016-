using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionIntegerToRomanNumbers
{
    class CovertIntToRoman
    {
        private int _Num;
        public CovertIntToRoman(int num)
        {
            this.Num = num;
        }

       
public int Num
        {
            get
            {
                return this._Num;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Please use a positive integer greater than zero.");
                }
                else if (value >= 1)
                {
                    this._Num = value;
                }
                else
                {
                    throw new FormatException("You must enter an integer number!");
                }
            }
        }
            public string CovertToRoman()
        {

            StringBuilder sb = new StringBuilder();
            int remain = Num;
            while (remain > 0)
            {
                if (remain >= 1000) { sb.Append("M"); remain -= 1000; }
                else if (remain >= 900) { sb.Append("CM"); remain -= 900; }
                else if (remain >= 500) { sb.Append("D"); remain -= 500; }
                else if (remain >= 400) { sb.Append("CD"); remain -= 400; }
                else if (remain >= 100) { sb.Append("C"); remain -= 100; }
                else if (remain >= 90) { sb.Append("XC"); remain -= 90; }
                else if (remain >= 50) { sb.Append("L"); remain -= 50; }
                else if (remain >= 40) { sb.Append("XL"); remain -= 40; }
                else if (remain >= 10) { sb.Append("X"); remain -= 10; }
                else if (remain >= 9) { sb.Append("IX"); remain -= 9; }
                else if (remain >= 5) { sb.Append("V"); remain -= 5; }
                else if (remain >= 4) { sb.Append("IV"); remain -= 4; }
                else if (remain >= 1) { sb.Append("I"); remain -= 1; }
                else throw new Exception("Unexpected error.");

            }

            return sb.ToString(); 
        }
        //public override string ToString()
        //{
        //    return base.ToString();
        //}

    }
    }

