using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day10
{
    internal class Temperature
    {
      
        public double ConvertToFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
           
        }
        public double ConvertToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

    }
}
