using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomChantry
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ivan = new Random();

            int textLength = ivan.Next(32768, 65537);

            StringBuilder brainFart = new StringBuilder();
            int lastWordLength = 0;

            while (brainFart.Length <= textLength)
            {
                lastWordLength = GenerateWord(ivan, brainFart, lastWordLength);

                int symbolDice = ivan.Next(10);

                if (symbolDice == 0)
                {
                    brainFart.Append('.');
                }
                else if (symbolDice <= 2)
                {
                    brainFart.Append(',');
                }

                brainFart.Append(' ');
            }

            Console.WriteLine(brainFart);
            string[] brokenDownText = brainFart.ToString().Split(new char[]{ ' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);

            do
            {
                string searchPattern = Console.ReadLine();
                int count = 0;
                for(int i = 0; i<brokenDownText.Length; i++)
                {
                    if(brokenDownText[i].ToLower() == searchPattern.ToLower())
                    {
                        count ++;
                    }
                }
                Console.WriteLine(count);
            } while (true);
        }

        /// <summary>
        /// Generates a word, inserts it into a StringBuilder and returns it's length.
        /// </summary>
        /// <param name="ivan">Random Generator object that defines the length of the word.</param>
        /// <param name="text">The string builder object which accepts the new word.</param>
        /// <param name="lastWordLength">The length of the last word, so that we can avoid two words with length 1.</param>
        /// <returns>The length of the newly generated word.</returns>
        static int GenerateWord(Random ivan, StringBuilder text, int lastWordLength)
        {
            int wordLength;

            if (lastWordLength == 1)
            {
                wordLength = ivan.Next(2, 11);
            }
            else
            {
                wordLength = ivan.Next(1, 11);
            }

            bool startsWithUpper = text.Length == 0 || text[text.Length - 2] == '.' || Convert.ToBoolean(ivan.Next(2));

            //if (text.Length == 0)
            //{
            //    startsWithUpper = true;
            //}
            //else if (text[text.Length - 1 - 2] == '.')
            //{
            //    startsWithUpper = true;
            //}
            //else
            //{
            //    startsWithUpper = Convert.ToBoolean(ivan.Next(2));
            //}

            int i = 0;
            if (startsWithUpper)
            {
                char letter = (char)ivan.Next(65, 91);
                text.Append(letter);
                i++;
            }

            while (wordLength > i++)
            {
                char letter = (char)ivan.Next(97, 123);
                text.Append(letter);
            }

            return wordLength;
        }
    }
}
