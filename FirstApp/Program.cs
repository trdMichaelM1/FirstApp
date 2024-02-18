using System;

namespace CSharpEssentials
{
    public class Company
    {
        public string Name { get; set; }

        public Company(string name)
        {
            Name = name;
        }
    }
    class Program
    {
        static void Print(Company company)
        {
            //if (company == null || company.Name == null)
            //{
            //    Console.WriteLine("Неизвестное имя");
            //}
            //else
            //{
            //    Console.WriteLine(company.Name);
            //}
            Console.WriteLine(company?.Name ?? "Неизвестное имя");
        }
        static void Main()
        {

        }
    }
}