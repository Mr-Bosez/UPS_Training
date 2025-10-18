using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day_7
{
    internal class SumOfEvenAndOdd
    {
        public void PrintEvenAndOdd() {
            int evenSum = 0;
            int oddSum = 0;
            Console.WriteLine("Enter the no of rows of the array: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no of columns of the array: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[rows, cols];
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (arr[i, j] % 2 == 0) 
                        evenSum += arr[i, j];
                    else
                        oddSum += arr[i, j];
                }
                //Console.WriteLine();
            }
            Console.WriteLine("The sum of even elements is: " + evenSum);
            Console.WriteLine("The sum of odd elements is: " + oddSum);
        }
    }
}
