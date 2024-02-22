using System;
using System.Collections.Generic;

namespace Stepik
{

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User { Name = "Alice", Age = 25 },
                new User { Name = "Bob", Age = 30 },
                new User { Name = "Charlie", Age = 35 }
            };

            List<User> filteredUsers = FilterUsers(users, u => u.Age > 25);

            foreach (var user in filteredUsers)
            {
                Console.WriteLine($"{user.Name} - {user.Age}");
            }
        }
        static List<User> FilterUsers(List<User> users, Func<User, bool> filterCriteria)
        {
            List<User> filteredUsers = new List<User>();
            foreach (var user in users)
            {
                if (filterCriteria(user))
                {
                    filteredUsers.Add(user);
                }
            }
            return filteredUsers;
        }
    }
}