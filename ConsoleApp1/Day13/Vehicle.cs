using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day13
{
    internal class Vehicle
    {
        protected String speed = "200 Km/hr";
        public virtual void SpeedUp()
        {
            Console.WriteLine(speed);
        }
    }

    internal class Car1 : Vehicle
    {
        
        public override void SpeedUp()
        {
            speed = "300 Km/hr";
            Console.WriteLine("Car speed increased to: " + speed);
        }
    }

    internal class Bicycle : Vehicle
    {
       
        public override  void SpeedUp()
        {
            speed = "20 Km/hr";
            Console.WriteLine("Bicycle speed increased to: " + speed);
        }
    }



   
}
