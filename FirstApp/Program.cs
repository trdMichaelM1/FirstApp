using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class Summator
    {
        protected virtual int Transform(int i)
        {
            return i;
        }

        public int Sum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Transform(i);
            }
            return sum;
        }
    }

    public class SquareSummator : Summator
    {
        protected override int Transform(int i)
        {
            return i * i;
        }
    }

    public class CubeSummator : Summator
    {
        protected override int Transform(int i)
        {
            return i * i * i;
        }
    }
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine(new Summator().Sum(5)); // 15
            Console.WriteLine(new SquareSummator().Sum(5)); // 55
            Console.WriteLine(new CubeSummator().Sum(5)); // 225
        }
    }
}