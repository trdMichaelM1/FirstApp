using System;

namespace CSharpEssentials
{
    public interface IInterfaceA
    {
        void Method1();
    }

    public interface IInterfaceB
    {
        void Method1();
    }

    public class MyClass : IInterfaceA, IInterfaceB
    {
        void IInterfaceA.Method1()
        {
            Console.WriteLine("IInterfaceA.Method1");
        }

        void IInterfaceB.Method1()
        {
            Console.WriteLine("IInterfaceB.Method1");
        }

        public void Method1()
        {
            Console.WriteLine("MyClass.Method1");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Method1();

            IInterfaceA a = myClass;
            a.Method1();

            IInterfaceB b = myClass;
            b.Method1();
        }
    }
}