using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day3
{
    internal class AllEvenNumbers
    {
        public void EvenNumbers()
        {
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Even numbers from 1 to " + number + " are:");
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
