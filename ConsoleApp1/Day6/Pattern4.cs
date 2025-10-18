using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day6
{
    internal class Pattern4
    {
        public void pattern()
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
