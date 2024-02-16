using System;

namespace CSharpEssentials
{
    public class Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static double LengthPoints(Point first, Point second)
        {
            return Math.Sqrt(Math.Pow((second.X - first.X), 2) + Math.Pow((second.Y - first.Y), 2));
        }
    }
    class Program
    {
        static void Main()
        {
            Point point1 = new Point(1, 5);
            Point point2 = new Point(5, 5);
            Console.WriteLine(Point.LengthPoints(point1, point2)); // 4
        }
    }
}