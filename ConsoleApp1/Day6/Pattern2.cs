using System;
using System.Collections.Generic;
using System.Text;

// 4321
//432
//43
//4


namespace ConsoleApp1.Day6
{
    internal class Pattern2
    {
        public void Pattern()
        {
            int n = 4;
            for (int i = 1; i <=n; i++)
            {
                for(int j = n; j >= i; j--)
                {
                    Console.Write(j+" ");

                }
                Console.WriteLine();
            }

        }

    }
}


