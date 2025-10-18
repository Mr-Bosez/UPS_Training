using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day5
{
    internal class ElementSearch
    {
        public void ElementSearchMethod()
        {
            Console.WriteLine("Enter the size of the array");
            int size=Convert.ToInt32( Console.ReadLine());  //5
            int[] arr = new int[size];
            for(int i=0;i<size;i++)
            {
                Console.Write($"Enter the element {i+1}");
                arr[i]=Convert.ToInt32(Console.ReadLine());     //arr=[10,20,30,40,50]
            }
            Console.WriteLine("Enter the element to be searched");
            int element = Convert.ToInt32(Console.ReadLine());    // 30
            for (int i=0;i<size;i++)
            {
                if(arr[i]==element)
                {
                    Console.WriteLine($"Element {element} is found in the array at index {i}.");
                    return;
                }
            }
            Console.WriteLine($"Element {element} is not found in the array.");

        }
    }
}
