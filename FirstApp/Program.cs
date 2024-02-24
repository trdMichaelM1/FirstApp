using System;

namespace CSharpEssentials
{
    public class SetAgeEventArgs : EventArgs
    {
        public string Message { get; }

        public SetAgeEventArgs(string message)
        {
            Message = message;
        }
    }

    public class User
    {
        private string name;
        private int age;

        //public event Action<string> MessageHandler;
        public event EventHandler<SetAgeEventArgs> MessageHandler;

        public void SetAge(string input)
        {
            if (int.TryParse(input, out int age))
            {
                if (age > 18 && age < 100)
                {
                    this.age = age;
                    MessageHandler?.Invoke(this, new SetAgeEventArgs("Возраст записан"));
                }
                else
                {
                    MessageHandler?.Invoke(this, new SetAgeEventArgs("Возраст должен быть числом между 18 и 100"));
                }
            }
            else
            {
                MessageHandler?.Invoke(this, new SetAgeEventArgs("Возраст должен быть числом"));
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
            user.MessageHandler += User_MessageHandler;
            user.SetAge(Console.ReadLine());
        }

        private static void User_MessageHandler(object sender, SetAgeEventArgs e)
        {
        }

        private static void ShowOnConsole(object sender, SetAgeEventArgs e)
        {
            Console.WriteLine($"Консоль: {e.Message}");
        }

        private static void SendEmail(object sender, SetAgeEventArgs e)
        {
            Console.WriteLine($"Почта: {e.Message}");
        }

        private static void SendSms(object sender, SetAgeEventArgs e)
        {
            Console.WriteLine($"Смс: {e.Message}");
        }
    }
}