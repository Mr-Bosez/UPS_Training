using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day11
{
    internal class Books
    {
        String author, title;

        public Books() {
            this.author = "Subash";
            this.title = "Biography of Subash Chandra Bose";
        
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title : {title}");
            Console.WriteLine($"The Author of this Book : {author}");
        }
    }
}
