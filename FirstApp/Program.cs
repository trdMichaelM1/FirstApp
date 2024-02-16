using System;

namespace CSharpEssentials
{
    public class A
    {
        static A()
        {
            Console.WriteLine("Да! Я понял как создавать статический конструктор!");
        }
    }
    
    
    class Program
    {
        static void Main()
        {
            A a = new A();
        }
    }
}