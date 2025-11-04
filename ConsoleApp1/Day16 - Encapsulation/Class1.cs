using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day16___Encapsulation
{
    internal class Class1
    {
        private protected void ShowMessage()
        {
            Console.WriteLine("Hello from class1!");
        }
    }

    //internal class Class2
    //{
    //    public static void Run()
    //    {
    //        Class1 obj = new Class1();
    //        obj.ShowMessage();

    //    }

    //}

    //Modifer
    // public => yes
    // private => no
    // protected => no
    // internal => yes
    // protected internal => yes
    // private protected => no



    // After Inheritance                                
    internal class Class2 : Class1
    {
        public static void Run()
        {
            Class2 obj = new Class2();
            obj.ShowMessage();

        }

    }

    //Modifer
    // public => yes
    // private => no
    // protected => yes
    // internal => yes
    // protected internal => yes
    // private protected => yes

    //internal class ClassB : Another_file.ClassA
    //{
    //    public static void Run()
    //    {
    //        Another_file.ClassA obj = new Another_file.ClassA();
    //        obj.msg();
    //    }
    //}

}



