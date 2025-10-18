using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day5
{
    internal class SelectionSort
    {
        public void selectionSort()
        {
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the element {i + 1} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Selection Sort Algorithm
            for (int i = 0; i < size - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Swap the found minimum element with the first element
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine("Array sorted in ascending order:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
