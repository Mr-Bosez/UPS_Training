using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day11
{
    internal class Employee
    {
        //String employeeName;
        decimal basicSalary, HRA, DA;
        public Employee() 
        {
            this.basicSalary = 3000m;
            this.HRA = 0.2m* basicSalary;
            this.DA=0.1m* basicSalary;
        
        }

        public void CalculateGrossSalary(String EmployeeName)
        {
            decimal grossSalary=basicSalary+HRA+ DA;
            Console.WriteLine($"The Gross Salary of employee {EmployeeName} is {grossSalary}");
        }
    }
}
