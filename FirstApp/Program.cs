using System;

namespace CSharpEssentials
{
    public enum Side
    {
        North, // север
        East,  // восток
        South, // юг
        West   // запад
    }

    class Program
    {
        public static void GoTo(Side side, int meters)
        {
            Console.WriteLine($"Go {side} for {meters} meters");
        }
        static void Main(string[] args)
        {
            GoTo(Side.East, 50);
            GoTo(Side.South, 20);
            GoTo(Side.West, 30);
            Console.WriteLine("You found it!");
        }
    }
}