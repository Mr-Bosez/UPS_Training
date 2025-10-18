using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day6
{
    internal class OddEvenPattern
    {
        int n = 5;
        public void Pattern()
        {
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    if((i+j)%2==0)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
