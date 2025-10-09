using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class GreatestOfThreeNum
    {

        public void greatestOfThreeNumber(int x, int y, int z)
        {
            if (x > y && x > z)
            {
                Console.WriteLine(x + " is the greatest among all the three numbers");
            }
            else if (y > z && y > x) {
                Console.WriteLine(y + " is the greatest among all the three numbers");
            }
            else
            {
                Console.WriteLine(z + " is the greatest among all the three numbers");
            }


        }
    }
}
