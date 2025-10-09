using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day2
{
    internal class LeapYearChecker
    {
        public void LeapYearCheck(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine(year + " is a Leap year");
            }
            else
            {
                Console.WriteLine(year + " is a Leap year");
            }
        }
    }
}
