using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day14
{
    interface IInterfaceSample
    {
        void Display();

    }

    internal class Dis:IInterfaceSample
    {
        public void Display()
        {
            Console.WriteLine("Interface Example");
        }

    }
    
}
