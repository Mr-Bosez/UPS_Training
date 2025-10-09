using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class checkSquareOrNot
    {
        public void check()
        {

            Console.Write("Enter the length :");
            int length=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the breadth :");
            int breadth=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((length == breadth) ? "Its square " : " Its rectangle");
        }

    }
}
