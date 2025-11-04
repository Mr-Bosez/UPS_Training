using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day18_LINQ
{
    internal class Task2
    {

        public static void DisplayHighSalaryEmployees()
        {
            var employees = new[]
            {
                new { Id = 1, Name = "Arun", Salary = 45000, Department = "IT" },
                new { Id = 2, Name = "Meena", Salary = 55000, Department = "HR" },
                new { Id = 3, Name = "Kumar", Salary = 30000, Department = "IT" },
                new { Id = 4, Name = "Priya", Salary = 60000, Department = "Finance" },
                new { Id = 5, Name = "Ravi", Salary = 40000, Department = "HR" }
            };


            Console.WriteLine("EMployee from HR Department:");
            var hrEmployees = employees.Where(e => e.Department == "HR");
            foreach (var emp in hrEmployees)
            {
                Console.WriteLine($"{emp.Name} : {emp.Department}");
            }
            var highSalaryEmployees = employees.Where(e => e.Salary > 45000).OrderBy(e => e.Salary);
            Console.WriteLine("Employees with Salary greater than 45000:");
            foreach (var emp in highSalaryEmployees)
            {
                Console.WriteLine($"{emp.Name} : {emp.Salary}");
            }

            Console.WriteLine("Names and Departments of all Employees:");
            var employeeDetails = employees.Select(e => new { e.Name, e.Department }).OrderBy(e => e.Name);
            foreach (var emp in employeeDetails)
            {
                Console.WriteLine($"{emp.Name} : {emp.Department}");
            }

            var averageSalary = employees.Average(e => e.Salary);
            Console.WriteLine($"Average Salary of Employees:{averageSalary}");

            Console.WriteLine("Employee with lowest salary:");
            var lowestSalaryEmployee = employees.OrderBy(e => e.Salary).First();
            Console.WriteLine($"{lowestSalaryEmployee.Name} : {lowestSalaryEmployee.Salary}");

        }
    }
}
