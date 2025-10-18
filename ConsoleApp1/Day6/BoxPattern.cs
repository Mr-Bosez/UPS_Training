using System;
using System.Collections.Generic;
using System.Text;
//output
//* * * * *
//*       *
//*       *
//*       *
//* * * * *

namespace ConsoleApp1.Day6
{
    internal class BoxPattern
    {
        int n=5;
        public void boxPattern()
        {
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    if(i==1 || i==n || j==1 || j==n)
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
