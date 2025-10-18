using System;
using System.Collections.Generic;
using System.Text;

//output
//A B C D E
//F G H I J
//K L M N O
//P Q R S T
//U V W X Y

namespace ConsoleApp1.Day6
{
    internal class PatternChar
    {
        char val = 'A';
        public void Pattern()
        {
            int n = 5;
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    Console.Write(val+" ");
                    val++;
                }
                Console.WriteLine();
            }
        }
    }
}
