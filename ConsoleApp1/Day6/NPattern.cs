using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day6
{
    internal class NPattern
    {
        int n = 5;
        public void pattern()
        {
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    if(j==1 || j==n || i==j)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
