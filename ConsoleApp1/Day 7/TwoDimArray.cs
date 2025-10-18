using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day_7
{
    internal class TwoDimArray
    {
        public void TwoDArray()
        {

            //int[,] arr = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
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

            for(int i = 0;i < rows; i++)
            {
                for(int j = 0;j < cols; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            

        }
    }

}
