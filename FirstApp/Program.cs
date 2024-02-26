using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class Product
    {
        public string Name { get; set; } // Имя 
        public double Price { get; set; } // Цена
        public int Quantity { get; set; } // Количество

        public override string ToString()
        {
            return $"Название: {Name}, Цена: {Price}, Количество: {Quantity}";
        }
    }

    public class Store : IEnumerable<Product>, IEnumerator<Product>
    {
        private readonly List<Product> products;
        private int idx = -1;

        public Store()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public Product Current => products[idx];

        object IEnumerator.Current => products[idx];

        public IEnumerator<Product> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            idx++;
            return idx < products.Count;
        }

        public void Reset()
        {
            idx = -1;
        }

        public void Dispose() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.AddProduct(new Product { Name = "Чайник", Price = 1000, Quantity = 3 });
            store.AddProduct(new Product { Name = "Мультиварка", Price = 3000, Quantity = 7 });
            store.AddProduct(new Product { Name = "Пылесос", Price = 7500, Quantity = 15 });

            foreach (var product in store)
            {
                Console.WriteLine(product);
            }
        }
    }
}