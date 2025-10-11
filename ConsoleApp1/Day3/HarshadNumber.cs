using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day3
{
    internal class HarshadNumber
    {
        public void CheckharshadNumber()    // example 18 = 1+8 = 9 and 18 is divisible by 9
        {  
            int sum = 0;
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int originalNumber = number;
            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            if (originalNumber % sum == 0)
            {
                Console.WriteLine(originalNumber + " is a Harshad Number.");
            }
            else
            {
                Console.WriteLine(originalNumber + " is not a Harshad Number.");
            }


        }
    }
}
