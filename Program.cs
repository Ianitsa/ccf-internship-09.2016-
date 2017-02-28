using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SomePoetry
{
    class Program
    {
        static void Main(string[] args)
        {
            textGenerator(20000,"a");

            Console.ReadLine();
        }


        //static void textGenerator(int textLentgh)
        //{
        //    string english = "abcdefghijklmnopqrstuvwxyz ";
        //    string text = "";
        //    int count = 0;
        //    Random r = new Random();
        //    for (int i = 0; i < textLentgh; i++)
        //    {   
        //        int randomInt = r.Next(0, 26);
        //        //Console.Write(randomInt);
        //        int randomComma = r.Next(0, 9);

        //        bool previousSybmolIsPunctuation = i > 0 && (text[i - 1].Equals('.') || text[i - 1].Equals(','));
        //        bool isRandomPunctuation = randomComma == 4 || randomComma == 9;

        //        if (isRandomPunctuation && !previousSybmolIsPunctuation)
        //        {
        //            if (randomComma == 4)
        //            {
        //                count += 1;
        //                text += '.';
        //                if (count == 5)
        //                {
        //                    text += Environment.NewLine;
        //                }
        //            }
        //            else
        //            {
        //                text += ",";
        //            }
        //        }
        //        else
        //        {
        //            if ( i > 0 && (text[i - 1].Equals('.')))
        //            {
        //                char temp = english[randomInt];
        //                temp = Char.ToUpper(temp);                        
        //                text += temp;                        
        //            }
        //            else if (i > 0 && (text[i - 1].Equals(',')))
        //            {
        //                text += " ";
        //            }
        //            else
        //            {
        //                if (i > 1 && (english[randomInt].Equals(text[i-2])))
        //                {
        //                    text += english[r.Next(0, 26)];
        //                }
        //                else
        //                {
        //                    text += english[randomInt];
        //                }                        
        //            }
        //        }

        //    }
        //    Console.WriteLine(text);
        // }



        //TextGenerator recieves textLength as int, representing the length of the text we need to generate
        // name recieves a value of type string, whitch we enter as a condition for the loop - it will stop
        // when it reaches a match with it.
        static void textGenerator(int textLength,string name)
        {

            string english = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder text = new StringBuilder();
            //string text = "";
            int count = 0;
            Random r = new Random();
            bool fullStop = true;
            string tempWord = "";
            for (int i = 0; i < textLength; i++)
            {                
                int randomPunctuation = r.Next(0, 24);
                int randomWordLength = r.Next(1, 10);
                StringBuilder word = new StringBuilder();
                // this loop generated words with random letters from the "english" string
                if (randomWordLength == name.Length)
                {
                }
                for (int j = 0; j < randomWordLength; j++)
                {
                    int randomInt = r.Next(0, 25);
                    // this condition checkes if the current word needs to begin with a capital letter
                    if (i == 0 || fullStop)
                    {
                        char temp = english[randomInt];
                        temp = Char.ToUpper(temp);
                        word.Append(temp);
                        fullStop = false;
                    }
                    else
                    {
                        word.Append(english[randomInt]);
                    }
                }
                
                if (!word.Equals(tempWord) || (word.Length == 1 && tempWord.Length != 1))
                // this condition first checks if the last word is not the same as the current word
                {
                    text.Append(word);
                    tempWord = word.ToString();

                    // this condition will break the loop if a word matches "name" and will write "Success" on a new line
                    if (word.ToString().Equals(name))
                    {
                        Console.WriteLine(Environment.NewLine + "Success! " + name + " was found in the text." + Environment.NewLine);
                        break;
                    }
                    // this condition gives the ", " a 20% chance to be appended at the end of our word
                    if (randomPunctuation == 4 || randomPunctuation == 9 || randomPunctuation == 14 || randomPunctuation == 19 || randomPunctuation == 24)
                    {
                        text.Append(", ");
                    }
                    // this condition gives the ". " a 4% chance to be appended at the end of our word 
                    else if (randomPunctuation == 20)
                    {
                        text.Append(". ");
                        fullStop = true;
                        count += 1;
                    }

                    // this condition will append an interval if there is no fullstop or comma inserted
                    else
                    {
                        text.Append(" ");
                    }
                }
                //counts the number of fullstops, so we can insert a new paragraph after 4 sentences
                if (count >= 4)
                {
                    text.Append(Environment.NewLine);
                    count = 0;
                }
                // this restarts the program untill it finds a match with "name"
                if (i == textLength - 1)
                {
                    text.Clear();
                    i = 1;
                }
            }
            Console.WriteLine(text);            
        }
    }
}
