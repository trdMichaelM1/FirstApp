using System;

namespace CSharpEssentials
{
    class Program
    {
        static void Main()
        {
            int x = 7;
            object y = x;
            //long l = (long)(int)y;
            long l = (int)y;
            Console.WriteLine(y);
        }
    }
}