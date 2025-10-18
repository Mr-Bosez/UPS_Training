using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day_7
{
    internal class TwoDArraySearch
    {
        bool found = true;
        public TwoDArraySearch()
        {
            Console.Write("Enter the no of rows of the array: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the no of columns of the array: ");
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
            Console.Write("Enter the element to be searched: ");
            int searchElement = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (arr[i, j] == searchElement)
                    {
                        Console.WriteLine($"Element {searchElement} found at position ({i},{j})");
                        found = false;
                    }
                }
            }
            if (found)
            {
                Console.WriteLine($"Element {searchElement} not found in the array");
            }
        }
    }
}
