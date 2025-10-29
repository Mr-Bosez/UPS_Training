using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day14
{
    interface IProducts
    {
        void ShowProductDetails();
    }

    internal class Book : IProducts
    {
        public void ShowProductDetails()
        {
            Console.WriteLine("Book");
        }
    }

    internal class Laptop : IProducts
    {
        public void ShowProductDetails()
        {
            Console.WriteLine("Laptop");
        }
    }

    internal class ProductFactory
    {
        public static IProducts GetProduct(string productType)
        {
            switch (productType.ToLower())
            {
                case "book":
                    return new Book();
                case "laptop":
                    return new Laptop();
                default:
                    throw new ArgumentException("Invalid product type");
            }
        }
    }
}
