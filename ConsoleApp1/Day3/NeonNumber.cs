using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day3
{
    internal class NeonNumber
    {

        public void CheckNeonNumber()    // example 9 = 9^2 = 81 => 8+1 = 9 and 9 is a Neon Number ,only 0,1,and 9 are Neon Numbers
        {
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int square = number * number;
            int sum = 0;
            while (square != 0)
            {
                int digit = square % 10;
                sum += digit;
                square /= 10;
            }
            if (sum == number)
            {
                Console.WriteLine(number + " is a Neon Number.");
            }
            else
            {
                Console.WriteLine(number + " is not a Neon Number.");
            }
        }
    }
}
