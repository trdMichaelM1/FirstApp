using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class Book : IComparable<Book>
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int ReleaseYear { get; set; }

        public int CompareTo(Book other)
        {
            int compare = Author.CompareTo(other.Author);
            if (compare == 0)
            {
                return ReleaseYear.CompareTo(other.ReleaseYear);
            }
            return compare;
        }

        public override string ToString()
        {
            return $"{Name}, {Author}, {ReleaseYear}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
                new Book
                {
                    Name = "Предел",
                    Author = "Сергей Лукьяненко",
                    ReleaseYear = 2021
                },

                new Book
                {
                    Name = "Порог",
                    Author = "Сергей Лукьяненко",
                    ReleaseYear = 2020
                },

                new Book
                {
                    Name = "Чистая архитектура",
                    Author = "Мартин Роберт",
                    ReleaseYear = 2018
                },

                new Book
                {
                    Name = "C# для профессионалов",
                    Author = "Скит Джон",
                    ReleaseYear = 2019
                }
            };

            Array.Sort(books);

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}