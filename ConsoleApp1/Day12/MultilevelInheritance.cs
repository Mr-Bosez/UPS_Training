using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ConsoleApp1.Day12
{
    internal class Personal
    {
        String name ="Subash", qualification="B-tech";
        int age=22;
        public Personal()
        {
            PersonalDetails();
        }


        public void PersonalDetails()
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Qualification : {qualification}");
        }
    }

    internal class Teacher : Personal
    {
        String subject1="maths", subject2="Computer Science";
        
        public Teacher()
        {
         
            TeacherDetails();
            
        }

        public void TeacherDetails() { 
            Console.WriteLine($"Subject Details");
            Console.WriteLine($"Subject 1: {subject1}");
            Console.WriteLine($"Subject 2 : {subject2}");
        }
    }

    internal class HeadTeacher: Teacher
    {
        String department = "Computer Science\n ECE\n EEE \n IT";
        public HeadTeacher()
        {
            
            HeadTeacherDetails();
        }
        public void HeadTeacherDetails()
        {
            Console.WriteLine($"The departments are: \n {department}");
        }
    }

    internal class ChoiceSelection
    {
        public int choice;
        public ChoiceSelection()
        {
            Console.WriteLine("Give the choice : \n 1.Personal \n 2. Teacher \n 3. HeadTeacher");
            this.choice=Convert.ToInt32( Console.ReadLine() ); 
            switch (choice)
            {
                case 1:
                    new Personal();
                    break;
                case 2:
                    new Teacher();
                    break;
                case 3:
                    new HeadTeacher();
                    break;
            }

        }
        
        

    }
}
