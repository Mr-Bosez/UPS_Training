using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day3
{
    internal class PerfectNumber
    {
        public void FindPerfectNumber()  // example 6 = 1+2+3  
        {
            int sum = 0;
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine(number + " is a Perfect Number.");
            }
            else
            {
                Console.WriteLine(number + " is not a Perfect Number.");
            }
        }
    }
}
