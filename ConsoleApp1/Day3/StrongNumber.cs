using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day3
{
    internal class StrongNumber
    {
        public void FindStrongNumber()
        {
         

            // to find the factorial of a number 
            int fact(int n)
            {
                int result = 1;
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
                return result;

            }


            int sum = 0;
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int originalNumber = number;
            while (number != 0)
            {
                int digit = number % 10;
                sum += fact(digit);
                number /= 10;
            }
            if (sum == originalNumber)
            {
                Console.WriteLine(originalNumber + " is a Strong Number.");
            }
            else
            {
                Console.WriteLine(originalNumber + " is not a Strong Number.");
            }

            
        }
    }
}
