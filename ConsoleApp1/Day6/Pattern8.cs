using System;
using System.Collections.Generic;
using System.Text;

//    1
//   1 2
//  1 2 3
// 1 2 3 4
//1 2 3 4 5

namespace ConsoleApp1.Day6
{
    internal class Pattern8
    {
        int n = 5;
        public void Pattern()
        {
            for(int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ',n-i));
                for(int j = 1; j <=i; j++)
                {

                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
