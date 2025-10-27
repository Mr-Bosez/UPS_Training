using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day11
{
    internal class ConstructorsOperations
    {
        int a, b;

        public ConstructorsOperations()
        {
            Console.WriteLine("Its is the default constructor");

        }

        public ConstructorsOperations(int num1,int num2)
        {
            a = num1;
            b = num2;

        }
       

        public void Add() 
        {
            Console.WriteLine($"The addition of two numbers {a} and {b} is : {a + b}");
        
        }
        public void Sub() 
        {
            Console.WriteLine($"The subtraction of two numbers {a} and {b} is : {a - b}");
        
        }
        public void Mul() 
        {
            Console.WriteLine($"The multiplication of two numbers {a} and {b} is : {a * b}");
        
        }
        public void Div() 
        {
            Console.WriteLine($"The division of two numbers {a} and {b} is : {a / b}");
        
        }

    }
}
