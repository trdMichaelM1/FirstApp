using System;

namespace CSharpEssentials
{
    struct Point
    {
        public int X;
        public int Y;
    }

    struct Line
    {
        public Point StartPoint;
        public Point EndPoint;
    }
    class Program
    {
        static void Main()
        {
            Line[] lines = new Line[5];
            Console.WriteLine(lines[0].StartPoint.X);
        }
    }
}