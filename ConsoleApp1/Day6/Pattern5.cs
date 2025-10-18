using System;
using System.Collections.Generic;
using System.Text;


// output
//1  2  3  4
//5  6  7  8
//9  10 11 12
//13 14 15 16

namespace ConsoleApp1.Day6
{
    internal class Pattern5
    {
        int val = 1;
        public void pattern()
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(val + " ");
                    val++;
                }
                Console.WriteLine();
            }
        }
    }
}
