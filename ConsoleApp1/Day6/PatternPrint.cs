using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day6
{
    internal class PatternPrint
    {
        public void StarPattern()
        {
           int n=5;
            for (int i=1;i<=n;i++)
              {
                 for(int j=1;j<=n;j++)
                 {
                      Console.Write("* ");
                 }
                 Console.WriteLine();
            }

        }
    }
}
