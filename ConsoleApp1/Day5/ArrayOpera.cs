using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day5
{
    internal class ArrayOpera
    {
        int evenCount=0, oddCount=0;
        public void ArrayOperations()
        {
            int[] arr= new int[10] {1,2,3,4,5,6,7,8,9,10};
            foreach (int i in arr) {
                if (i % 2 == 0) evenCount++;
                else oddCount++;
            }
            Console.WriteLine($"{evenCount} even numbers and {oddCount} odd numbers in the array." );
            // array copy
            int[] arr2 = new int[arr.Length];
            Array.Copy(arr, arr2, arr.Length);
            foreach (int i in arr2)
            {
                Console.Write(i+" ");
            }
            // reverse
            Console.WriteLine("Reversed Array");
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(i + " ");
            }

            // second largest
            Array.Sort(arr);
            Console.WriteLine($"\nsecond largest element {arr[arr.Length - 2]}");

            //ascend
            Console.WriteLine("Array sorted in ascending order");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            //descending
            Console.WriteLine("Array sorted in descending order");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            //merge
            int count = 0;
            int[] arr3 = new int[4] { 1, 2, 3, 4 };
            int[] arr4= new int[4] { 5, 6, 7, 8 };
            int[] arr5 = new int[arr3.Length+arr4.Length];
            for(int i = 0; i < arr3.Length; i++)
            {
                arr5[count++] = arr3[i];
            }
            for(int i = 0; i < arr4.Length; i++)
            {
                arr5[count++] = arr4[i];
            }
            foreach(int i in arr5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int[] dupArr = new int[6] { 1, 2, 3, 1, 3, 4 };
            int[] distinctArr = dupArr.Distinct().ToArray();
            Console.WriteLine(String.Join(',', distinctArr));

            // frequency
            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int num in dupArr)
            {
                if (freq.ContainsKey(num))
                {
                    freq[num]++;  
                }
                else
                {
                    freq[num] = 1;
                }
                
            }
            Console.WriteLine("Element with frequencies");
            foreach (var item in freq)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
            


        }
    }
}
