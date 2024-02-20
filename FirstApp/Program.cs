using System;

namespace CSharpEssentials
{

    class Program
    {
        public static void PrintArray<T>(T[] array)
        {
            foreach(T t in array)
            {
                Console.WriteLine(t);
            }
        }

        static void Main()
        {
            string[] names = { "Josef", "Vadim", "Ivan" };
            PrintArray(names);

        }
    }
}