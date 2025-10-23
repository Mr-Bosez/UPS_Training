using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day10
{
    internal class EvenNumbersArray
    {
        
        public static int[] GetEvenNumbers(int[]nums)
        {
            
            return nums.Where(n => n % 2 == 0).ToArray();

        }
    }
}
