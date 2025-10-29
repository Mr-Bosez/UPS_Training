using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day13
{
    // Overloading methods  => static polymorphism
    internal class Addition
    {
        public int Add(int a,int b)
        {
            //Console.WriteLine($"base class");
            return a + b;
            

        }
        public double Add(double a,double b)
        {
            return a + b;
            //Console.WriteLine($"The sum of {a} and {b} is {a+b}");

        }
        public String Add(String a,String b)
        {
            return a + b;
            //Console.WriteLine($"The concatenation of {a} and {b} is {a+b}");
        }

    }

    // Overriding methods => dynamic polymorphism
    internal class Subraction: Addition
    {
        public int Add(int a, int b)
        {
            int x=base.Add(a,b); // calling base class method


            Console.WriteLine($"Subtraction of {a} and {b} : {a-b}");
            return x;
        }
        

    }
}
