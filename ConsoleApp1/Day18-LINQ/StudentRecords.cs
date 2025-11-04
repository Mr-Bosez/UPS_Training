using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day18_LINQ
{
    internal class Student
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public String Department { get; set; }

    }
    internal class StudentRecords
    {
        static List<Student> records=new List<Student>()
        {
            new Student{ Id = 1, Name = "Arun", Marks = 85, Department = "IT" },
            new Student{ Id = 2, Name = "Meena", Marks = 92, Department = "HR" },
            new Student{ Id = 3, Name = "Kumar", Marks = 45, Department = "IT" },
            new Student{ Id = 4, Name = "Priya", Marks = 78, Department = "Finance" },
            new Student{ Id = 5, Name = "Ravi", Marks = 88, Department = "IT" }

,

        };

        public static void DisplayRecords()
        {
            var studentData = records.Select(data => new {data.Name,data.Marks});
            foreach (var record in studentData)
            {
                Console.WriteLine($"{record.Name} : {record.Marks}");
            }
        }

        public static void HighScore()
        {
            var highestMark = records.Where(data => data.Marks > 80).Select(data => new { data.Name });
            Console.WriteLine("Students Scored more than 80");
            foreach (var record in highestMark)
            {
                Console.WriteLine($"{record.Name}");
            }
        }

        public static void DisplayMarkInDesc()
        {
            var stu = records.OrderByDescending(data => data.Marks).Select(data => new {data.Name, data.Marks}) ;
            Console.WriteLine("Marks in descending Order");
            foreach (var record in stu)
            {
                Console.WriteLine($"{record.Name} : {record.Marks}");
            }

        }

        public static void TotalScore() {
            int Total = records.Sum(data => data.Marks);
            Console.WriteLine($"Total marks : {Total}");
        }

        public static void DisplayHighScoreDetails()
        {
            var stu = records.OrderByDescending(data => data.Marks).First();
            Console.WriteLine($"{stu.Name} {stu.Marks} {stu.Department}");


        }
    }
}
