using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day_7
{
    internal class PrimeNumbersInArray
    {
        public void PrintPrimeNumbers()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 elements in the array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The prime numbers in the array are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                bool isPrime = true;

                if (arr[i] <= 1)
                    isPrime = false;
                else
                {
                    for (int j = 2; j <= arr[i] / 2; j++)
                    {
                        if (arr[i] % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                    Console.Write(arr[i] + " ");
            }
        }
    }
}
