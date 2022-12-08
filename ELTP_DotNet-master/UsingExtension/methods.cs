using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingExtension
{
    public sealed class methods
    {      
        
            public int GetLength(string str)
            {
                return str.Length;
            }

        public string ChangeCase(string str, char c)
        {
            if (c == 'l') return str.ToLower();
            if (c == 'u') return str.ToUpper();
            return str;
        }
        }


        public static class StringExtensions
        {
            public static string ReverseString(this methods op, string str)
            {
                string reverse = String.Empty;
                for (var i = str.Length - 1; i >= 0; i--)
                {
                    reverse += str[i];
                }
                return reverse;
            }

        //public static string ReverseExt(this string str)
        //{
        //    string reverse = String.Empty;
        //    for (var i = str.Length - 1; i >= 0; i--)
        //    {
        //        reverse += str[i];
        //    }
        //    return reverse;
        //}

        
        public static string CountStatement(this methods op, string str)
        {
            int wordCount = 1, statementCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    wordCount++;
                }
                if (Char.IsDigit(str[i]))
                {
                    //Console.WriteLine($"index: {i} value {str[i]}");
                    if (str[i + 1] == '.')
                    {
                        statementCount--;
                    }
                }
                if (str[i] == '.')
                {
                    statementCount++;
                }
            }
            var splittedText = str.Split();
            for (int i = 0; i < splittedText.Length; i++)
            {
                if (splittedText[i].Contains(".com") || splittedText[i].Contains(".edu") || splittedText[i].Contains(".in") || splittedText[i].Contains(".org") || splittedText[i].Contains(".co"))
                {
                    statementCount--;
                }
            }
            return Convert.ToString(statementCount);
        }
    }
    }


