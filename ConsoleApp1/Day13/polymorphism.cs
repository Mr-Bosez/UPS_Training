using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day13
{
    internal class Polymorphism
    {
     
        public virtual void Vehicle()
        {
            Console.WriteLine("This is a vehicle");
        }

    }

    internal class Car : Polymorphism
    {
        public override void Vehicle()
        {
            Console.WriteLine("This is a car");
        }
    }

    internal class Bike : Polymorphism
    {
        public override void Vehicle()
        {
            Console.WriteLine("This is a bike");
        }
    }
}
