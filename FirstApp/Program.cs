using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class Car
    {
        public string Model { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Model}, Цена: {Price}";
        }
    }

    public class CarShowroom
    {
        private readonly List<Car> cars;
        private int idx = -1;
        public CarShowroom(List<Car> cars)
        {
            this.cars = cars;
        }

        public Car Current => cars[idx];

        public CarShowroom GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            idx++;
            return idx < cars.Count;
        }

        public void Reset()
        {
            idx = -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>
            {
               new Car { Model = "Lada", Price = 250000 },
               new Car { Model = "Mercedes", Price = 500000 },
               new Car { Model = "BMW", Price = 350000}
            };

            CarShowroom shop = new CarShowroom(myCars);
            foreach (var car in shop)
            {
                Console.WriteLine(car);
            }
        }
    }
}