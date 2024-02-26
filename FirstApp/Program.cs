using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class Product : IEquatable<Product>
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }

        public Product(string name, int price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $"Product: Название: {Name}, Цена: {Price}, Категория: {Category}";
        }

        public bool Equals(Product other)
        {
            bool name = Name == other.Name;
            bool price = Price == other.Price;
            bool category = Category == other.Category;

            return (name && price) || (name && category) || (price && category);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Яблоко", 200, "Фрукты");
            Product product2 = new Product("Помидор", 150, "Овощи");
            Product product3 = new Product("Яблоко", 150, "Фрукты");

            Console.WriteLine(product1.Equals(product3)); // True
            Console.WriteLine(product2.Equals(product3)); // False
        }
    }
}