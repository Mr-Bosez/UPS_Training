using System;
using System.Collections.Generic;
using System.Text;

// output
//*
//* *
//*   *
//*     *
//* * * * *

namespace ConsoleApp1.Day6
{
    internal class RightAngledStar
    {
        int n = 5;
        public void Pattern()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if(j==1|| i==n||i==j) Console.Write("* ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
}
