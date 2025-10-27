using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day11
{
    internal class StudentDetails
    {
        String name, grade;
        int age;

        public StudentDetails(String name, int age, String grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Student Name :{name}");
            Console.WriteLine($"Student Age :{age}");
            Console.WriteLine($"Student Grade :{grade}");
        }
    }
}
