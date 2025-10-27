using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day12
{
    internal class ClassA
    {
        public int Add(int x,int y) { 
            return x + y;
        }

    }
    internal class ClassB : ClassA
    {
        public int Sub(int x,int y) { 
            return x - y;
        }

    }
    internal class ClassC : ClassB
    {
        public int Mul(int x,int y) { 
            return x * y;
        }

    }
    internal class ClassD : ClassC
    {
        public int Div(int x,int y) { 
            return x / y;
        }

    }
}
