using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day3
{
    internal class PalindromeNumber
    {
        public void Palindrome()
        {
            int reverse = 0, remainder;
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int originalNumber = number;
            while (number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }
            if (originalNumber == reverse)
            {
                Console.WriteLine(originalNumber + " is a palindrome.");
            }
            else
            {
                Console.WriteLine(originalNumber + " is not a palindrome.");
            }
        }
    }
}
