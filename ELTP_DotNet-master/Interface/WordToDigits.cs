using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class WordsToDigits
    {
        public string GetStringforDigit(int digit)
        {
            //1231235
            string OutString = string.Empty;
            List<string> word = new List<string>();
            int count = 1, pre = digit % 10;
            List<string> wordstring1 = new List<string>() { "","one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
        "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            List<string> wordstring2 = new List<string>() { "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "nighty" };


            while (digit > 0)
            {
                int temp = digit % 10;
                if (count == 1)
                {
                    word.Add(wordstring1[temp]);

                }

                else if (count == 2)
                {
                    if (temp == 1)
                    {
                        word.Clear();
                        word.Add(wordstring1[pre + 10]);
                    }
                    else if (temp != 0)
                    {

                        word.Add(wordstring2[temp - 1]);
                    }


                }
                else if (count == 3)
                {
                    word.Add("hundred");

                    word.Add(wordstring1[temp]);

                }
                else if (count == 4)
                {

                    word.Add("thousand");

                    word.Add(wordstring1[temp]);


                }
                else if (count == 5)
                {
                    if (temp == 1)
                    {
                        word.RemoveAt(word.Count - 1);
                        word.Add(wordstring1[pre + 10]);
                    }
                    else if (temp != 0)
                    {
                        word.Add(wordstring2[temp - 1]);
                    }
                }
                else if (count == 6)
                {
                    word.Add("lakh");
                    word.Add(wordstring1[temp]);
                }
                else if (count == 7)
                {
                    if (temp == 1)
                    {
                        word.RemoveAt(word.Count - 1);
                        //word.Remove(word[word.Count - 1]);
                        word.Add(wordstring1[pre + 10]);
                    }
                    else if (temp != 0)
                    {
                        word.Add(wordstring2[temp - 1]);
                    }
                }
                else if (count == 8)
                {
                    word.Add("crore");
                    word.Add(wordstring1[temp]);
                }
                else if (count == 9)
                {
                    if (temp == 1)
                    {
                        word.RemoveAt(word.Count - 1);
                        word.Add(wordstring1[pre + 10]);
                    }
                    else if (temp != 0)
                    {
                        word.Add(wordstring2[temp - 1]);
                    }
                }
                else if (count == 10)
                {
                    word.Add("crore");
                    word.Add(wordstring1[temp]);
                }
                else if (count == 11)
                {
                    if (temp == 1)
                    {
                        word.RemoveAt(word.Count - 1);
                        word.Add(wordstring1[pre + 10]);
                    }
                    else if (temp != 0)
                    {
                        word.Add(wordstring2[temp - 1]);
                    }
                }
                count++;
                pre = temp;
                digit /= 10;
            }
            word.Reverse();
            foreach (var v in word)
                OutString = OutString + v + " ";
            return OutString;
        }
    }
}
