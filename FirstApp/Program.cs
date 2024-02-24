using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public interface IUsersStorage
    {
        List<User> GetAll();
        User TryGetById(int id);
        void Add(User user);
        bool RemoveById(int id);
        bool UpdateById(int id, string name, int age);
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class UsersInMemoryStorage : IUsersStorage
    {
        private readonly List<User> users;
        public UsersInMemoryStorage()
        {
            users = new List<User>();
        }

        public List<User> GetAll()
        {
            return users;
        }

        public User TryGetById(int id)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                    return user;
            }
            return null;
        }

        public void Add(User user)
        {
            users.Add(user);
        }

        public bool RemoveById(int id)
        {
            User user = TryGetById(id);
            if (user != null)
                return users.Remove(user);
            return false;
        }

        public bool UpdateById(int id, string name, int age)
        {
            User user = TryGetById(id);
            if (user != null)
            {
                user.Name = name;
                user.Age = age;
                return true;
            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IUsersStorage usersStorage = new UsersInMemoryStorage();
            List<User> users = usersStorage.GetAll();
            Console.WriteLine(users.Count == 0); // True

            User user = usersStorage.TryGetById(5);
            Console.WriteLine(user == null); // True

            usersStorage.Add(new User { Id = 1, Name = "Josef", Age = 26 });
            usersStorage.Add(new User { Id = 2, Name = "Mark", Age = 27 });
            Console.WriteLine(users.Count == 2); // True

            user = usersStorage.TryGetById(2);
            Console.WriteLine(user.Name == "Mark"); // True

            Console.WriteLine(usersStorage.UpdateById(2, "Andrew", 27)); // True
            Console.WriteLine(usersStorage.RemoveById(2)); // True
        }
    }
}