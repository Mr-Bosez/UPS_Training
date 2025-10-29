using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day13
{
    internal class EmployeeSalary
    {
        protected String role;
        public virtual void CalculateSalary() { }
    }
    internal class Manager :EmployeeSalary
    {
        public override void CalculateSalary()
        {
            role = "Manager";
            int salary = 80000;
            Console.WriteLine("Salary calculated for " + role + "role is : "+salary);

        }
    }
    internal class Programmer : EmployeeSalary
    {
        public override void CalculateSalary()
        {
            role = "Programmer";
            int salary = 120000;
            Console.WriteLine("Salary calculated for " + role + "role is : " + salary);

        }
    }
}
