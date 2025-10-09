using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day2
{
    internal class QuadrantCheck
    {
        public void FindQuadrant(double x,double y) {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("The points " + x + " and " + y + " lies in first quadrant");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("The points " + x + " and " + y + " lies in Second quadrant");
            }
            else if (x <0 && y <0) {
                Console.WriteLine("The points " + x + " and " + y + " lies in Third quadrant");
            }
            else if (x >0 && y <0) {
                Console.WriteLine("The points " + x + " and " + y + " lies in Fourth quadrant");
            }
            else
            {
                Console.WriteLine("The points " + x + " and " + y + " lies in Origin");
            }
            
          
        }
    }
}
