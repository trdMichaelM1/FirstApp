using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    class Integer
    {
        private int value;

        public Integer(int n)
        {
            value = n;
        }

        void Print()
        {
            Console.WriteLine($"value: {value}");
        }

        public static int operator *(Integer a, int b)
        {
            return a.value * b;
        }

        public static double operator *(Integer a, double b)
        {
            return a.value * b;
        }
    }

    class Program
    {
        static void Main()
        {
            Integer integer1 = new Integer(15);
            Integer integer2 = new Integer(8);

            Console.WriteLine(integer1 * 3); // 45
            Console.WriteLine(integer2 * 2.5); // 20
        }
    }
}