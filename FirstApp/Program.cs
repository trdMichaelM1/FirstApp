using System;

namespace CSharpEssentials
{
    class Program
    {
        delegate void MyDelegate();

        private static void Method1()
        {
            Console.Write("Hello");
        }

        private static void Method2()
        {
            Console.Write("Hi");
        }

        static void Main(string[] args)
        {
            MyDelegate myDelegate = Method1;
            myDelegate += Method2;
            myDelegate -= Method1;
            myDelegate -= Method2;

            myDelegate?.Invoke();
        }
    }
}