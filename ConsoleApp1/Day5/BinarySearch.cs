using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day5
{
    internal class BinarySearch
    {
        public void search() {
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the element {i + 1} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the element to be searched : ");
            int element = Convert.ToInt32(Console.ReadLine());
            Array.Sort(arr); 
            int left = 0, right = size - 1;
            while (left <= right)
            {
                int mid = (left + right)/ 2;
                if (arr[mid] == element)
                {
                    Console.WriteLine($"Element {element} is found in the array at index {mid}.");
                    return;
                }
                else if (arr[mid] < element)
                {
                    left = mid + 1;
                }
                else if (arr[mid] > element)
                {
                    right = mid - 1;
                }
                else { 
                    Console.WriteLine($"Element {element} is not found in the array.");
                }
            }
        }
    }
}
