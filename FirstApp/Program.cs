using System;

namespace CSharpEssentials
{
    class Program
    {
        static void Main()
        {
            string line = null;

            string name = line ?? throw new ArgumentNullException("line");
            Console.WriteLine(name);
        }
    }
}