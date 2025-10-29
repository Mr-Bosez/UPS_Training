using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day13
{
    internal class AreaCalculations
    {
        public virtual double GetArea() { return 0; }
        public virtual double GetPerimeter() { return 0; }
    }

    internal class Circle : AreaCalculations
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }


        public override double GetArea()
        {
            double area = Math.PI * radius * radius;
            return area;
        }
        public override double GetPerimeter()
        {
            double perimeter = 2 * Math.PI * radius;
            return perimeter;
        }
    }

    internal class Rectanglee : AreaCalculations
    {
        private double length,breadth;
        public Rectanglee(double length,double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override double GetArea() {
            double area= length * breadth;
            return area;
        }
        public override double GetPerimeter()
        {
            double perimeter = 2 * (length + breadth);
            return perimeter;
        }
    }

    internal class Triangle : AreaCalculations
    {
        private double side1, side2, side3;
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override double GetArea()
        {
            double s = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            return area;
        }
        public override double GetPerimeter()
        {
            double perimeter = side1 + side2 + side3;
            return perimeter;
        }
    }
}
