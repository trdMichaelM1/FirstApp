using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class Product
    {
        public string Name;
        public decimal Price;
        public string Category;

        public Product(string name, decimal cost, string category)
        {
            Name = name;
            Price = cost;
            Category = category;
        }
    }
    class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>()
            {
                new Product("product1", 10, "furniture"),
                new Product("product2", 100, "toy"),
                new Product("product3", 1000, "toy"),
                new Product("product4", 10000, "toy"),
                new Product("product5", 100000, "furniture")
            };

            SelectAndChangePrice(products, "toy", 10, SelectCategory, IncreasePrices);

            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Category} - {product.Price}");
            }
        }

        static void SelectAndChangePrice(List<Product> products, string category, int n,
            Func<Product, string, bool> selectCategory, Action<Product, int> increasePrices)
        {
            foreach (Product product in products)
            {
                if (selectCategory(product, category))
                    increasePrices(product, n);
            }
        }
        static void IncreasePrices(Product product, int n)
        {
            product.Price = product.Price * (1 + n / 100M);
        }
        static bool SelectCategory(Product product, string category)
        {
            return product.Category.Equals(category);
        }
    }
}