using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day2
{
    internal class discount
    {
        public void disc()
        {
            int quantity;
            double pricePerItem = 100; // You can change this if needed

            Console.Write("Enter quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            double totalCost = quantity * pricePerItem;

            // Apply discount if total cost > 1000
            if (totalCost > 1000)
            {
                double discount = totalCost * 0.10;  // 10% discount
                totalCost = totalCost - discount;
                Console.WriteLine("You received a 10% discount!");
            }

            Console.WriteLine("Total cost to be paid: " + totalCost);
        }
    }
}
