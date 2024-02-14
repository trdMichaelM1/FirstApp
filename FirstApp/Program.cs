using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public static bool operator >(User a, User b)
        {
            return a.Age > b.Age;
        }

        public static bool operator <(User a, User b)
        {
            return a.Age < b.Age;
        }
    }

    class Program
    {
        static void Main()
        {
            User user1 = new User("Josef", 25);
            User user2 = new User("Mark", 26);

            Console.WriteLine(user1 > user2); // False
            Console.WriteLine(user1 < user2); // True
        }
    }
}