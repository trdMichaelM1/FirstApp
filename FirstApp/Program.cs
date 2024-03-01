using System;

namespace CSharpEssentials
{
    public class UserAgeInvalidException : Exception
    {
        public int InvalidAge { get; }
        public UserAgeInvalidException() { }
        public UserAgeInvalidException(string m, int invalidAge) : base(m)
        {
            InvalidAge = invalidAge;
        }
    }

    public class User
    {
        private string name;
        private int age;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Имя не может быть пустым!");
                }
                name = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 18 || value > 150)
                {
                    // инициирование своего исклюения
                    throw new UserAgeInvalidException("Возраст должен быть от 18 до 150", value);
                }
                age = value;
            }
        }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user = new User("Josef", 266);
            }
            catch (UserAgeInvalidException e)
            {
                // логика!

                // получение дополнительной информации
                Console.WriteLine(e.InvalidAge);

            }
        }

    }
}