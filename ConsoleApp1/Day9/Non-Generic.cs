using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day9
{
    internal class Non_Generic
    {
        public  Non_Generic()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(6);
            arrayList.Add(19);
            arrayList.Add('N');
            arrayList.Add('S');
            arrayList.Add(true);

            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
