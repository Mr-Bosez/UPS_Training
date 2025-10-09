using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp1
{
    internal class TemperatureState
    {
        public void Temp(double temperature)
        {
            switch (temperature)
            {
                case double t when t < 0:
                    Console.WriteLine("Freezing Weather");
                    break;

                case double t when t >= 0 && t < 10:
                    Console.WriteLine("Very Cold Weather");
                    break;

                case double t when t >= 10 && t < 20:
                    Console.WriteLine("Cold weather");
                    break;

                case double t when t >= 20 && t<30:
                    Console.WriteLine("Normal in Temp");
                    break;
                case double t when t >= 30 && t<40:
                    Console.WriteLine("Hot");
                    break;
                case double t when t >= 40:
                    Console.WriteLine("Its very Hot");
                    break;

                default:
                    Console.WriteLine("Unknown temperature");
                    break;
            }
        }

    }
}
