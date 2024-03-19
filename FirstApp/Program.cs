using System;
using System.IO;
using System.Text;

namespace CSharpEssentials
{    
    class Program
    {
        static void Main(string[] args)
        {
            int size = sizeof(decimal);
            Console.WriteLine(size);

            int x1 = 10;
            int x2 = 20;
            (x1, x2) = (x2, x1);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            bool isTrue = true & false;
            Console.WriteLine(isTrue);

            // Delay
            Console.ReadKey();
        }

    }
}