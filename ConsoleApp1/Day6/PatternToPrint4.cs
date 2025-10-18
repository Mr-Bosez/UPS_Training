using System;
using System.Collections.Generic;
using System.Text;

//*
//**
//**
//*****
//  *


namespace ConsoleApp1.Day6
{
    internal class PatternToPrint4
    {
        int n = 5;
        public void Pattern()
        {
            for(int i=1; i <= n; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    if(i==4||(j==1&&i<n)|| (j==3&& i > 1)) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
