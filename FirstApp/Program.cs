using System;

namespace CSharpEssentials
{
    public class Phone
    {
        public string Name { get; }
        public decimal Cost { get; }
        public Phone(string name, decimal cost)
        {
            // здесь поддержать ограничения параметров
            if (name == null)
                throw new ArgumentNullException("Имя не может быть равно null!");

            if (name.Length < 2 || name.Length > 50)
                throw new ArgumentException("Имя должно содержать от 2 до 50 символов!");

            if (cost < 1)
                throw new ArgumentException("Значение цены должно быть положительным!");
            Name = name;
            Cost = cost;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }

    }
}