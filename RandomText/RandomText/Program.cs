using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomText
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue = 32000;
            int maxValue = 64000;
            //  string text = "aAbBcCdDiIfFgGhHiIjJkKlLmMNnoOpPqQrRsStTuUvVwWxXyYzZ";
            string textCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string textSmall = "abcdefghijklmnopqrstuvwxyz";
            string simbols = " .,";
            string quots = ",";
            string tab = "/t";

            Random randam = new Random();
            var textList = new StringBuilder();
            var list = new List<string>();

            int pastIterationletter = 0;
            int howManyLetters = 0;

            while (0 < minValue--)
            {

                string letter = "";


                 
                pastIterationletter = howManyLetters;
                howManyLetters = randam.Next(1, 11);
 
                if (!(pastIterationletter == 1 && howManyLetters == 1))
                {
                    for (int j = 1; j <= howManyLetters; j++)
                    {
                        

                        if (j == 1)
                        {
                            int rnd = randam.Next(25);
                            letter = textCaps.ElementAt(rnd).ToString();
                            textList.Append(letter);
                        }
                        else
                        {
                            int rnd = randam.Next(25);
                            letter = textSmall.ElementAt(rnd).ToString();
                            textList.Append(letter);
                        }

                    }

                    textList.Append(simbols[randam.Next(simbols.Length)]);
                }

                 


                


                for (int j = textList.Length - howManyLetters - 1; j < textList.Length; j++)
                {
                    //??
                    textList[j] = Char.ToLower(textList[j]);

                    if (j >= 2)
                    {
                        if ((textList[j - 2] == '.' || textList[j - 2] == ',') && !textList[j - 1].Equals(' '))
                        {
                            textList.Insert(j - 1, ' ');
                        }

                        if (textList[j - 2].Equals('.') && textList[j - 1].Equals(' '))
                        {
                            textList[j] = Char.ToUpper(textList[j]);
                            //string charOfText = textList[j + 2].ToString();
                            //charOfText= charOfText.ToUpper();
                        }

                        //if (textList[j-1]=='')
                        //{

                        //}
                    }

                    

                }



            }


            
            Console.WriteLine(textList);

            Console.Read();
        }
    }
}


