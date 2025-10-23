using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day10
{
    internal class PalindromeChecker
    {
        public bool IsPalindromeInt(int number)
        {
            String original=number.ToString();
            String reversed=Reverse(original);
            return reversed==original;
        }
        public bool IsPalindromeWord(String word)
        {
            String original=word;
            String reversed= Reverse(original);
            return reversed==original;
        }
        public String Reverse(String wordOrLetter)
        {
            char[] chars=wordOrLetter.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
