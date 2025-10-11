using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day3
{
    internal class SpyNumber
    {
        public void FindSpyNumber() { 
            int product = 1;
            int sum = 0;
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                product *= digit;
                number /= 10;
            }
            if (sum == product)
            {
                Console.WriteLine("The number is a Spy Number.");
            }
            else
            {
                Console.WriteLine("The number is not a Spy Number.");
            }
        }
    }
}
