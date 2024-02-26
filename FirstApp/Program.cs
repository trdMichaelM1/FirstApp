using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class Book : IEquatable<Book>
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int ReleaseYear { get; set; }

        public bool Equals(Book other)
        {
            return Name.Equals(other.Name) && Author.Equals(other.Author) && ReleaseYear.Equals(other.ReleaseYear);
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

        }
    }
}