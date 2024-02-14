using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class A
    {
        public static int operator +(A a, A b)
        {
            return 0;
        }

        public static int operator *(A a, string b)
        {
            return 0;
        }
    }
    
    class Program
    {
        static void Main()
        {
            int a = new A() + new A() + new A() * "abc";
        }
    }
}