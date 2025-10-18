using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day5
{
    internal class InsertionSort
    {
        public void insertionSort()
        {
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the element {i + 1} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Insertion Sort Algorithm
            for (int i = 1; i < size; i++)
            {
                int key = arr[i];
                int j = i - 1;
                // Move elements of arr[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            Console.WriteLine("Array sorted in ascending order:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
