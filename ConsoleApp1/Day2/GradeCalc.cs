using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day2
{
    internal class GradeCalc
    {
        public void gradecal(int totalMark)
        {
            if (totalMark >=450 && totalMark <=500) {
                Console.WriteLine("A Grade ");
            }
            else if (totalMark >=400 && totalMark <=450) {
                Console.WriteLine("B Grade ");
            }
            else if (totalMark >=350 && totalMark <=400) {
                Console.WriteLine("C Grade ");
            }
            else if (totalMark >=300 && totalMark <=350) {
                Console.WriteLine("D Grade ");
            }
            else if (totalMark >=250 && totalMark <=300) {
                Console.WriteLine("E Grade ");
            }
            else if (totalMark >=0 && totalMark <=350) {
                Console.WriteLine("fAILED");
            }

        }
    }
}
