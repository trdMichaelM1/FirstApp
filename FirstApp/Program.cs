using System;

namespace CSharpEssentials
{
    public class Person { }
    class Program
    {
        static void Main()
        {
            Person person = new Person();

            object obj = person; // upcasting
            Console.WriteLine(obj);

            person = obj as Person; // downcasting
            Console.WriteLine(obj);
            if (obj is Person)
                person = (Person)obj; // downcasting
            Console.WriteLine(obj);
        }
    }
}