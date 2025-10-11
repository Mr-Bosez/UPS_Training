using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day3
{
    internal class SumOfDigits
    {
        public void sumDigits()
        {
            int sum = 0;
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            Console.WriteLine("The sum of digits is: " + sum);
        }
    }
}
