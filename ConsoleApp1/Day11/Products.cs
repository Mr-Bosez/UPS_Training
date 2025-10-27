using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day11
{
    internal class Products
    {
        String productName;
        int PQuantity;

        //Products() { }

        public Products(String productName, int PQuantity)
        {
            this.productName = productName;
            this.PQuantity = PQuantity;
        }

        public Products(Products prdts) { 
         productName = prdts.productName;
          PQuantity = prdts.PQuantity;
        }

        public void DisplayProducts()
        {
            Console.WriteLine($"Product Name :{productName}");
            Console.WriteLine($"Product Quantity :{PQuantity}");
        }
    }
}
