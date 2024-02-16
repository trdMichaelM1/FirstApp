using System;

namespace CSharpEssentials
{
    public class ProductDb
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }

    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
    }

    public static class Helper
    {
        public static ProductViewModel ToProductViewModel(this ProductDb product)
        {
            return new ProductViewModel() { Id = product.Id, Name = product.Name, Cost = product.Cost };
        }
    }

    class Program
    {
        static void Main()
        {
            var productDb = new ProductDb()
            {
                Id = Guid.NewGuid(),
                Name = "Молоко",
                Cost = 120,
                Description = "Натуральное молоко из деревни",
                ImagePath = "https://lenta.gcdn.co/globalassets/1/-/10/20/65/346818_2.png?preset=fulllossywhite"
            };

            ProductViewModel productViewModel = productDb.ToProductViewModel();

            Console.WriteLine(productViewModel.Name); // Молоко
            Console.WriteLine(productViewModel.Cost); // 120
        }
    }
}