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

    public class PowerSummator : Summator
    {
        protected int P { get; set; }
        public PowerSummator(int p)
        {
            P = p;
        }

        protected override int Transform(int i)
        {
            return (int)Math.Pow(i, P);
        }
    }

    public class SquareSummator : PowerSummator
    {
        public SquareSummator() : base(2) { }
    }

    public class CubeSummator : PowerSummator
    {
        public CubeSummator() : base(3) { }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine(new Summator().Sum(5)); // 15
            Console.WriteLine(new PowerSummator(1).Sum(5)); // 15

            Console.WriteLine(new SquareSummator().Sum(5)); // 55
            Console.WriteLine(new PowerSummator(2).Sum(5)); // 55

            Console.WriteLine(new CubeSummator().Sum(5)); // 225
            Console.WriteLine(new PowerSummator(3).Sum(5)); // 225
        }
    }
}