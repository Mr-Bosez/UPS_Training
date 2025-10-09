using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day2
{
    internal class CalculateElectricityBill
    {

        public void calcEleBill(int x)
        {
            if (x >= 0 && x <= 100)
            {
                Console.WriteLine("Free of cost");
            }
            else if (x >= 200 && x <= 500) {
                Console.WriteLine("Electricity bill for "+x+" units is "+(x*5));
            }
            else if (x >= 500 && x <= 1000) {
                Console.WriteLine("Electricity bill for "+x+" units is "+(x*7.25));
            }
            else if (x >1000) {
                Console.WriteLine("For the units above 1000 contact the electric board");
            }
        }
    }
}
