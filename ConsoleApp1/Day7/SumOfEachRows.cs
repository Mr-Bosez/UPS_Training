using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day_7
{
    internal class SumOfEachRows
    {
        public void SumOfRows() {
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
            Console.WriteLine("The array in matrix form :");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0;i < rows; i++)
            {
                int rSum = 0;
                for(int j = 0;j < cols; j++)
                {
                    rSum += arr[i, j];

                }
                Console.WriteLine($"Sum of row {i+1} is : {rSum}");
            }

        }
    }
}
