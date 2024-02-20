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

        public override string ToString()
        {
            return $"{Name}, {Age}";
        }
    }

    class Program
    {
        // шаблон правила
        delegate void Rule(User user);

        // правило-метод LongNameRule
        private static void LongNameRule(User user)
        {
            if (user.Name.Length > 10)
                user.Name = user.Name.Substring(0, 10);
        }

        private static void IncreaseAge(User user)
        {
            user.Age++;
        }

        private static List<User> TransformUsersByRule(List<User> users, Rule rule)
        {
            foreach (var user in users)
            {
                rule(user);
            }
            return users;
        }

        static void Main()
        {
            List<User> users = new List<User>
            {
                new User("namenamename", 25),
                new User("1234567890", 34),
                new User("123456", 14),
            };

            Rule rules = LongNameRule;
            rules += IncreaseAge;

            List<User> transformedUsers = TransformUsersByRule(users, rules);

            foreach (var user in transformedUsers)
            {
                Console.WriteLine(user);
            }
        }
    }
}