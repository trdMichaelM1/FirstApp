using System;

namespace CSharpEssentials
{
    class Program
    {
        static void Main()
        {
            var anonymous = new { Name = "Test", Age = 18 };
            Console.WriteLine(anonymous.Name);
            Console.WriteLine(anonymous.Age);
        }
    }
}