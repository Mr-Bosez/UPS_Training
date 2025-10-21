using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day9
{
    internal class StudentsMarkDictionary
    {
        public StudentsMarkDictionary() { 
            Dictionary<int ,List<int>> studentsMarks = new Dictionary<int ,List<int>>();
            int totalStudents = 3;
            int totalSubjects = 5;
            for (int i = 0; i < totalStudents; i++) {
                Console.WriteLine("Enter the student id :");
                int id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the marks of a student one by one:");
                List<int>marks=new List<int>();
                for (int j = 0; j < totalSubjects; j++) {
                    marks.Add(Convert.ToInt32(Console.ReadLine()));
                }
                studentsMarks[id]=marks;
            }



            foreach (var i in studentsMarks) {
                Console.WriteLine($"{i.Key}: {string.Join(", ", i.Value)}");
            }

            double overallTotal = 0;
            int overallCount = 0;
            int topStudentId = -1;
            int topTotalMarks = 0;
            // Average marks of each student
            foreach (var i in studentsMarks) {
                Console.WriteLine($"Student id {i.Key} average marks : {i.Value.Average()}");
                int totalMark = i.Value.Sum();
                if (totalMark > topTotalMarks) {
                    topStudentId = i.Key;
                    topTotalMarks = totalMark;
                }

                overallTotal += totalMark;
                overallCount += i.Value.Count();
                
            }
            double overallAverage=overallTotal/overallCount;

            Console.WriteLine("=== Summary ===");
            Console.WriteLine($"Student with Highest Total Marks: {topStudentId} (Total: {topTotalMarks})");
            Console.WriteLine($"Overall Average Marks: {overallAverage:F2}");
        }
    }
}
