using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class Point : IEquatable<Point>
    {
        public double Latitude { get; set; } // Широта
        public double Longitude { get; set; } // Долгота

        public override string ToString()
        {
            return $" Координаты точки: {Latitude} широты, {Longitude} долготы";
        }

        public Point(double Latitude, double Longitude)
        {
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }

        public bool Equals(Point other)
        {
            int difference = 5;
            return Math.Abs(other.Latitude - Latitude) <= difference && Math.Abs(other.Longitude - Longitude) <= difference;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 2);
            Point point2 = new Point(4, 2);
            Point point3 = new Point(15, 5);
            Console.WriteLine(point1.Equals(point2)); // True
            Console.WriteLine(point1.Equals(point3)); // False
        }
    }
}