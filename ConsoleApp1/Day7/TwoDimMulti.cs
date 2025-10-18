using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day_7
{
    internal class TwoDimMulti
    {
        public TwoDimMulti() {
            Console.Write("Enter the no of rows of the array1: ");
            int rows1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the no of columns of the array1: ");
            int cols1 = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[rows1, cols1];
            Console.WriteLine("Enter the elements of the array1: ");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The array1 in matrix form :");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Second Array
            Console.Write("Enter the no of rows of the array2: ");
            int rows2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the no of columns of the array2: ");
            int cols2 = Convert.ToInt32(Console.ReadLine());
            int[,] arr1 = new int[rows2, cols2];
            Console.WriteLine("Enter the elements of the array2: ");
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The array2 in matrix form :");
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }

            if(cols1 != rows2)
            {
                Console.WriteLine("Matrix multiplication not possible");
                return;
            }

            int [,]arr2 = new int[rows1, cols2];
            for(int i=0; i < rows1; i++)
            {
                for(int j = 0; j < cols2; j++)
                {
                    for(int k = 0; k < cols1; k++)
                    {
                        arr2[i, j] += arr[i, k] * arr1[k, j];
                    }
                }
            }
            Console.WriteLine("The resultant array after multiplication is :");
            for (int i=0; i < rows1; i++)
            {
                for(int j = 0; j < cols2; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
