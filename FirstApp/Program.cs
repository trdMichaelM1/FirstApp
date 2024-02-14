using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class GeometricArea
    {
        public double CalculateArea(int r)
        {
            return Math.PI * r * r;
        }

        public double CalculateArea(int a, int b)
        {
            return a * b;
        }

        public double CalculateArea(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    class Program
    {
        static void Main()
        {
            // Круг
            GeometricArea circle = new GeometricArea();
            Console.WriteLine(circle.CalculateArea(3)); // 28,274

            // Прямоугольник
            GeometricArea rectangle = new GeometricArea();
            Console.WriteLine(rectangle.CalculateArea(3, 4)); // 12

            // Треугольник
            GeometricArea triangle = new GeometricArea();
            Console.WriteLine(triangle.CalculateArea(3, 4, 5)); // 6
        }
    }
}