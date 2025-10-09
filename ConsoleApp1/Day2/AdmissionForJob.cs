using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day2
{
    internal class AdmissionForJob
    {
        public void job()
        {
            Console.WriteLine("Enter the Aptitude mark");
            int apt=Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine("Enter the GD mark");
            int Gd=Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine("Enter the Technical mark");
            int tech=Convert.ToInt32(Console.ReadLine()); 
            
            Console.WriteLine("Enter the HR mark");
            int hr=Convert.ToInt32(Console.ReadLine());

            if (apt >= 85 && Gd >= 90 && tech >= 80 && hr >= 95)
            {
                Console.WriteLine("Eligible to apply for job");
            }
            else
                Console.WriteLine("Not eligible to apply");

            
        }
    }
}
