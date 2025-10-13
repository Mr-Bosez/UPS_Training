using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day4
{
    internal class Array_demo
    {

        public void arr_demo()
        {
            int[] age = { 1, 2, 30, 45, 12 };
            Console.WriteLine(age.Length); 

            Array.Sort(age);
            foreach (int i in age)
                Console.WriteLine(i);

            Array.Reverse(age);
            foreach (int i in age)
                Console.WriteLine(i);

            int[] copy = new int[age.Length];
            Array.Copy(age, copy, age.Length);
            foreach (int i in copy)
                Console.WriteLine(i);

            Array.Clear(age, 1, 3);  // Clears elements from index 1 to index 3
            foreach (int i in age)
                Console.WriteLine(i);

            int a = Array.IndexOf(age, 30);
            int l = Array.LastIndexOf(age, 20);

            Array.Resize(ref age, 7); //5 to 7
            age[5] = 98;
            age[6] = 26;
            Console.WriteLine(age.Length);

            string result = string.Join(", ", age);

            //using System.Linq;
            Console.WriteLine(age.Contains(45));
            int sum = age.Sum();
            int min = age.Min();
            int max = age.Max();
            double avg = age.Average();
            Console.WriteLine(sum);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(result);

        }
    }
}
