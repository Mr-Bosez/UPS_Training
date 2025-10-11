using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day3
{
    internal class SumOfNumbers
    {
        public void Sum()
        {
            int sum = 0;
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("The sum of " + number + " numbers is: " + sum);
        }
    }
}
