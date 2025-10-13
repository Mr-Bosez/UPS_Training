using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day4
{
    internal class ArrayFromUser
    {
        public static void arra()
        {
            Console.Write("Enter the size of the array : ");
            int size=Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            for(int i=0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the elements of the array : ");
            foreach (int i in arr)
            {
                Console.Write(i+" , "); 
            }

            int sum = 0;
            foreach(int i in arr)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("\nThe largest element in the array is "+arr.Max());
            Console.WriteLine("The smallest element in the array is "+arr.Min());
            Console.WriteLine("The Sum of all even element in the array is "+sum);
        }
    }
}
