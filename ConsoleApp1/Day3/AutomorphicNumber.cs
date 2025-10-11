using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1.Day3
{
    internal class AutomorphicNumber
    {
        public void automorphicNumber()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());  //25

            int square = num * num;  //625

            String num1 = num.ToString();
            String num2 = square.ToString();
            if (num2.EndsWith(num1))
            {
                Console.WriteLine("Its Automorphic");
            }
            else
                Console.WriteLine("Its not automorphic");
        }

    }
}
