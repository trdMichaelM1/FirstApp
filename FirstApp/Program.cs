using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    delegate void Method(int x);
    class Program
    {
        static void Main()
        {
            Method method1 = M1;
            method1 += M2;
            method1 += M1;
            method1 -= M2;
        
        }

        private static void M1(int x)
        {
            Console.WriteLine($"M1: x={x}");
        }

        private static void M2(int x)
        {
            Console.WriteLine($"M2: x={x}");
        }
    }
}