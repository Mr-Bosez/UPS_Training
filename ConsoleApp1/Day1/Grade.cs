using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day1
{
    internal class Grade
    {
        public void Mark(int marks)
        {
            if (marks > 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (marks > 80 && marks <90)
            {
                Console.WriteLine("Grade B");
            }
            if (marks > 60 && marks<80)
            {
                Console.WriteLine("Grade c");
            }
            else if(marks <60)
            {
                Console.WriteLine("Grade D");
            }
        }
    }
}
