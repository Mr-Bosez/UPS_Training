using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class CalcEmployeeBonus
    {

        public void empBonus()
        {
            int salary;
            int yearsOfService;
            double bonus = 0;
            Console.Write("Enter salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter years of service: ");
            yearsOfService = Convert.ToInt32(Console.ReadLine());
            if (yearsOfService > 5)
            {
                bonus = salary * 0.05; // 5% bonus
                Console.WriteLine("Congratulations! You are eligible for a bonus.");
            }
            else
            {
                Console.WriteLine("Sorry, you are not eligible for a bonus.");
            }
            Console.WriteLine("Employee bonus: " + bonus);
        }
    }
}
