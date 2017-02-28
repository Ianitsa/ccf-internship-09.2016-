using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringGenerator
{
    class Program
    {
        const int maxLower = 122;
        const int minLower = 97;
        const int maxUpper = 90;
        const int minUpper = 65;
        
        static void Main(string[] args)
        {
            StringBuilder all = new StringBuilder();

            Random random = new Random();
            int charCount = 0;
            int sentenceCount = 0;
            int counter = 0;

            while (counter <= random.Next(32000, 64000))
            {
                StringBuilder word = new StringBuilder();
                
                if (charCount >= 1)
                {
                    charCount = random.Next(2, 11);
                }
                else
                {
                    charCount = random.Next(1, 11);
                }

                // UPPER
                if (counter == 0 || all[all.Length - 2] == '.' || all[all.Length - 1] == '\n')
                    word.Append((char)random.Next(minUpper, maxUpper));
                
                // LOWER
                for (int j = 0; j < charCount; j++)
                {
                    word.Append((char) random.Next(minLower, maxLower));
                }

                counter += charCount;
                all.Append(word + " ");

                // .
                if (random.Next(1, 10) == 1)
                { 
                    all[all.Length - 1] = '.';
                    all.Append(" ");
                    sentenceCount++;

                    if (random.Next(3, 10) <= sentenceCount)
                    {
                        all.Append("\n");
                        sentenceCount = 0;
                    }
                }
                // ,
                else
                {
                    if (random.Next(1, 5) == 1)
                    {
                        all[all.Length - 1] = ',';
                        all.Append(" ");
                    }
                }
            }
            all[all.Length - 2] = '.';
            Console.WriteLine(all.ToString());

            // pattern (word |input\.|input,)
            string pattern;
            do
            {
                Console.WriteLine("\nSearch word");
                string input = Console.ReadLine();
                pattern = "(" + input + " |" + input + "\\.|" + input + ",)+";
                Console.WriteLine("Word: {0} {1}", input, Regex.IsMatch(all.ToString(), pattern) ? "is match" : "is not match");
                var matches = Regex.Matches(all.ToString(), pattern);
                Console.WriteLine("Number of matches: " + matches.Count);
            } while (pattern != "exit");
            
        }
    }
}
