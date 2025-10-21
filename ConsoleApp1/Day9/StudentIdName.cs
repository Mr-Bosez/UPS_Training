using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day9
{
    internal class StudentIdName
    {
        public StudentIdName() { 
            Dictionary<int ,String> dic = new Dictionary<int ,String>();
            int students = 5;
            for(int i = 0; i < students; i++)
            {
                Console.WriteLine("Enter the id ");
                int id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the student name");
                dic.Add(id, Console.ReadLine());
            }

            Console.Write("Enter the id of student to be searched : ");
            int stuId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The name of respective student id :" + dic[stuId]);

            Console.Write("Enter the student id to be removed: ");
            int idRem = Convert.ToInt32(Console.ReadLine());
            dic.Remove(idRem);
            foreach(var i in dic)
            {
                Console.WriteLine(i.Value);
            }
       

        
        }
    }
}
