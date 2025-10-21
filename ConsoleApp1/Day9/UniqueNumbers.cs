using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day9
{
    internal class UniqueNumbers
    {
        public UniqueNumbers() { 
            HashSet<int> numbers = new HashSet<int>();
            Console.WriteLine("Enter the numbers 1 by 1 ;");
            for (int i = 0; i < 10; i++) { 
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Displaying the unique numbers :");
            foreach (int i in numbers) Console.WriteLine(i);

            Console.Write("Enter the number to be searched : ");
            int searchNum=Convert.ToInt32(Console.ReadLine());
            if (numbers.Contains(searchNum)) Console.WriteLine($"{searchNum} is found in the set");
            else Console.WriteLine($"{searchNum} not found in the set");
        }
    }
}
