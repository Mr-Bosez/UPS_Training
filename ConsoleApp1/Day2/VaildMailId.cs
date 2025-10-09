using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1.Day2
{
    internal class VaildMailId
    {
        public void pass()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            if (username.Length > 5 && username.Length < 20)
            {
                Console.WriteLine("Valid username ");
            }
            else
                Console.WriteLine("Not a valid user name");

            if (email.Contains("@") && email.Contains(".") && email.IndexOf("@") < email.IndexOf("."))
            {
                Console.WriteLine("Vaild email");
            }
            else
            {
                Console.WriteLine("Invalid email");
            }
        }
    }
}
