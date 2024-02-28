using System;

namespace CSharpEssentials
{
    class Program
    {
        static void Do()
        {
            string[] data = Read();
            // Do
            Print(data);
        }
        static string[] Read()
        {
            string line = Console.ReadLine();
            return line.Split();
        }

        static void Print(string[] array)
        {
            for (int i = 0; i <= array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                int x = 10;
                Do();
            }
            catch
            {
                Console.WriteLine("Упс! Произошло исключение!");
            }
        }
    }
}