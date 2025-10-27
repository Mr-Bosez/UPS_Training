using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day11
{
    internal class Rectangle
    {

        private double length, width;

        public Rectangle()
        {
            this.length = 1.0;
            this.width = 1.0;
        }


        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public Rectangle(double side)
        {
            this.length = side;
            this.width = side;

        }

        public double CalculateArea()
        {
            return length * width;

        }
    }
}
