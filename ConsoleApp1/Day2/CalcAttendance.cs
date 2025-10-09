using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day2
{
    internal class CalcAttendance
    {
        public void attendance()
        {
            int totalDays;
            int daysPresent;
            double attendancePercentage;
            Console.Write("Enter total number of working days: ");
            totalDays = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of days present: ");
            daysPresent = Convert.ToInt32(Console.ReadLine());
            attendancePercentage = ((double)daysPresent / totalDays) * 100;
            Console.WriteLine("Attendance Percentage: " + attendancePercentage + "%");
            if (attendancePercentage < 75)
            {
                Console.WriteLine("Warning: Attendance is below 75%. You may not be eligible to attend the exams.");
            }
            else
            { 
                Console.WriteLine("Good job! You are allowed to sit in the exam.");
            }
        }
    }
}
