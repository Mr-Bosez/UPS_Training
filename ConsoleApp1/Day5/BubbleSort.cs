using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day5
{
    internal class BubbleSort
    {
        public void bubbleSort()
        {
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the element {i + 1} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Bubble Sort Algorithm
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Array sorted in ascending order:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
