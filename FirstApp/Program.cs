using System;

namespace CSharpEssentials
{
    public class User
    {
        private string name;
        private int age;

        public event Action<string> MessageHandler;
        
        public void SetAge(string input)
        {
            if (int.TryParse(input, out int age))
            {
                if (age > 18 && age < 100)
                {
                    this.age = age;
                    MessageHandler?.Invoke("Возраст записан");
                }
                else
                {
                    MessageHandler?.Invoke("Возраст должен быть числом между 18 и 100");
                }
            }
            else
            {
                MessageHandler?.Invoke("Возраст должен быть числом");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.MessageHandler += ShowOnConsole;
            user.MessageHandler += SendEmail;
            user.SetAge(Console.ReadLine());
        }

        private static void ShowOnConsole(string message)
        {
            Console.WriteLine(message);
        }

        private static void SendEmail(string message)
        {
            Console.WriteLine($"Send an emain \"{message}\"");
        }
    }
}