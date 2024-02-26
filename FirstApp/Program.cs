using System;
using System.Collections;

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
    }

    public class UserStorage : IEnumerable, IEnumerator
    {
        private readonly User[] users;
        private int index = -1;

        public UserStorage(User[] users)
        {
            this.users = users;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public object Current
        {
            get
            {
                return users[index];
            }
        }

        public bool MoveNext()
        {
            index++;
            if (index >= users.Length)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Josef", 26);
            User user2 = new User("Mark", 27);

            User[] users = new User[] { user2, user1 };

            UserStorage storage = new UserStorage(users);

            foreach(var user in storage)
            {

                Console.WriteLine(((User)user).Name);
            }
        }
    }
}