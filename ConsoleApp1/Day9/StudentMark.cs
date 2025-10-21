using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day9
{
    internal class StudentMark
    {

        public StudentMark() {
            List<int> marks = new List<int>();
            Console.WriteLine("Enter the Total number of students");
            int sub=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark scored by each student");
            for (int i = 0; i < sub; i++) { 
                marks.Add(Convert.ToInt32(Console.ReadLine()));
            }
            double aveargeMark= marks.Average();
            Console.WriteLine("The average mark is : " + marks.Average());
            Console.WriteLine("The highest mark is : " + marks.Max());
            Console.WriteLine("The lowest mark is : " + marks.Min());

            Console.WriteLine("Students scored above average marks : "+marks.Count(m => m > aveargeMark));


            
        }
    }
}
