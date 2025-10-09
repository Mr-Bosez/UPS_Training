using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp1
{
    internal class Calc
    {

       public void Value(int x,int y,String op)
        {
            if (op == "add")
            {
                //Console.WriteLine
                Console.WriteLine("Addition of two numbers :"+(x+y));
            }
            else if(op == "sub")
            {
                Console.WriteLine("Subtraction of two numbers :"+(x - y));
            }
            else if( op == "mul")
            {
                Console.WriteLine("Multiplication of two numbers : " + (x * y));
            }
            else if (op == "div")
            {
                Console.WriteLine("Division of two values :" + (x / y));
            }
        }


  
    }
}
