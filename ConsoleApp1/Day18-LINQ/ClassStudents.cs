using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day18
{
    internal class ClassStudents
    {
        public string Name { get; set; }
        public int Marks { get; set; } 
    }

    internal class StudentDetails11
    {
        static List<ClassStudents> studentsData = new List<ClassStudents>()
        {
            new ClassStudents(){ Name="Alice", Marks=85 },
            new ClassStudents(){ Name="Bob", Marks=92 },
            new ClassStudents(){ Name="Charlie", Marks=78 },
            new ClassStudents(){ Name="Diana", Marks=90 }
        };

        public static void DisplayStudentDetails()
        {
            int topStudentCount = studentsData.Count(data=>data.Marks>80);
            //foreach (var student in topStudent) {
            //    Console.WriteLine($"{student.Name} : {student.Marks}");
            //}
            Console.WriteLine($"Count :{topStudentCount}");
        }

    }
}
