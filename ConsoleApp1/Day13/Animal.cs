using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day13
{
    internal class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    internal class Bird : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cuckooo...");
        }
    }
    internal class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("memow..");
        }
    }
}
