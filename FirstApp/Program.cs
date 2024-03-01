using System;

namespace CSharpEssentials
{
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException() { }
        public InvalidPasswordException(string message) : base(message) { }
    }

    public class User
    {
        public string Name;
        private string password;

        public User(string name, string password) 
        {
            Name = name;
            Password = password;
        }
        public string Password
        {
            get => password;
            set
            {
                if (value.Length < 5)
                    throw new InvalidPasswordException("Слишком короткий пароль");

                password = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user = new User("Nik", "1234");
            }
            catch(InvalidPasswordException e)
            {
                Console.WriteLine(e.Message); // Слишком короткий пароль
            }

            try
            {
                User user = new User("May", "9736295637");
                Console.WriteLine(user.Password); //9736295637
            }
            catch(InvalidPasswordException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}