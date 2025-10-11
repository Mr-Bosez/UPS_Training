using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day3
{
    internal class SumOfEvenNumbers
    {
        public void EvenSum()
        {
            int sum = 0;
            int count = 0;
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                    count++;
                }
            }
            Console.WriteLine("The sum of even numbers from 1 to " + number + " is: " + sum);
            Console.WriteLine("The count of even numbers from 1 to " + number + " is: " + count);
        }
    }
}
