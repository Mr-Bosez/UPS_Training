using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day14
{

    internal abstract class IUniversity
    {
        public abstract void SubmitApplication(string studentName);
        public abstract void VerifyDocuments(int marks);
        public abstract void ConductInterview(int interviewScore);
        public abstract void AnnounceResults(int marks, int interviewScore);
    }

    internal class HarvardUniversity : IUniversity
    {
        public override void SubmitApplication(string studentName) => Console.WriteLine($"The applicant name : {studentName}");
        public override void VerifyDocuments(int marks) {
            if (marks > 90) Console.WriteLine("Congrats ! You are eligible to apply");
            else Console.WriteLine("Sorry , you are not eligible");
        }
        public override void ConductInterview(int interviewScore) => Console.WriteLine($"Interview Score : {interviewScore}");

        public override void AnnounceResults(int marks, int interviewScore)
        {
            int totalMarks = marks + interviewScore;

            Console.WriteLine((totalMarks > 150) ? $" Congrats ! You got selected in Harvard University" : "Sorry ! You didn't scored enough marks");
        }

    }
    internal class StanfordUniversity : IUniversity
    {
        public override void SubmitApplication(string studentName) => Console.WriteLine($"The applicant name : {studentName}");
        public override void VerifyDocuments(int marks)
        {
            if (marks > 90) Console.WriteLine("Congrats ! You are eligible to apply");
            else Console.WriteLine("Sorry , you are not eligible");
        }
        public override void ConductInterview(int interviewScore) => Console.WriteLine($"Interview Score : {interviewScore}");

        public override void AnnounceResults(int marks, int interviewScore) { 
            int totalMarks=marks+interviewScore;

            Console.WriteLine((totalMarks>150)?$"Congrats ! You got selected in Stanford University": "Sorry ! You didn't scored enough marks");
        } 
    }

    internal class UniversityFactory
    {
        public static IUniversity GetResults(String universityName)
        {
            switch (universityName.ToLower())
            {
                case "stanford":
                    return new StanfordUniversity();
                case "harvard":
                    return new HarvardUniversity();
                default:
                    throw new ArgumentException("Invalid University name");
            }
        }
    }
}
