using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day17
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    internal class AgeExceptionHandling
    {
        public void Age(int age)
        {
            try
            {
                if(age < 18)
                {
                    throw new InvalidAgeException("Age must be greater than 18.");
                }
                Console.WriteLine("Valid age: " + age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
