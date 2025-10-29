using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day14
{
    internal abstract class AbstractClass1
    {
        public abstract void Add(int num1, int num2);
        public abstract void Sub(int num1, int num2);

        public void Mul(int num1, int num2)
        {
            Console.WriteLine("Multiplication: " + (num1 * num2));
        }

        public void Div(int num1, int num2)
        {
            Console.WriteLine("Division: " + (num1 / num2));
        }
    }
    internal class Class1: AbstractClass1
    {
        public override void Add(int num1, int num2)
        {
            Console.WriteLine("Addition: " + (num1 + num2));
        }
        public override void Sub(int num1, int num2)
        {
            Console.WriteLine("Subtraction: " + (num1 - num2));
        }
        
    }
}
