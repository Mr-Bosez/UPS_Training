using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day10
{
    internal class Tasks
    {
        public void IsValidMail() {
            Console.Write("Enter the mail id :");
            String mail = Console.ReadLine();
            if (mail.Contains('@')&&mail.Contains('.'))  Console.WriteLine($"{mail} is a valid mail id");
            else Console.WriteLine($"{mail} is not a valid mail id");
        }

        public void ElectricBill()
        {
            decimal slab1 = 1.5m;
            decimal slab2 = 2.5m;
            decimal slab3 = 3.0m;

            Console.Write("Enter the units :");
            int unit = Convert.ToInt32(Console.ReadLine());
            decimal bill = 0;
            if (unit <= 100) bill = unit * slab1;
            else if(unit<=300) bill= (100*slab1)+(unit-100)*slab2;
            else bill= 100 * slab1 + 200 * slab2 + (unit - 300) * slab3;

            Console.WriteLine("========= ELECTRIC BILL ==========");
            Console.WriteLine($"The electric bill for {unit} units is : {bill}");
        }
    }
}
