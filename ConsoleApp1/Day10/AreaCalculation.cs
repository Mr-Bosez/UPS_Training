using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day10
{
    internal class AreaCalculation
    {
        public static double Calculate(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double Calculate(double length, double width)
        {
            return length * width;
        }

        public static double Calculate(double baseLength, double height, bool isTriangle)
        {
            if (isTriangle)
                return 0.5 * baseLength * height;
            else
                throw new ArgumentException("Invalid call for triangle area calculation");
        }


    }
}
