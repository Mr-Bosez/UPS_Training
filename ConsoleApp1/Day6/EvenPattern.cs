using System;
using System.Collections.Generic;
using System.Text;

// output
//2 4 6 8
//10 12 14 16
//18 20 22 24
//26 28 30 32

namespace ConsoleApp1.Day6
{
    internal class EvenPattern
    {
        int even= 2;
        public void Pattern()
        {
            int n = 4;
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    Console.Write(even + " ");
                    even += 2;
                }
                Console.WriteLine();
            }
        }
    }
}
