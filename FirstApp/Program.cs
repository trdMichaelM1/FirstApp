using System;

namespace CSharpEssentials
{
    public enum Colors
    {
        Red,
        Black,
        Yellow,
        White
    }

    public enum Languages
    {
        English,
        Russian
    }

    class Program
    {
        public static string ColorTranslate(Colors color, Languages language)
        {
            string[] colors = new string[] { "Красный", "Черный", "Желтый", "Белый" };
            if (language == Languages.English)
                return color.ToString();
            return colors[(int)color];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ColorTranslate(Colors.Red, Languages.Russian)); // Красный
            Console.WriteLine(ColorTranslate(Colors.Red, Languages.English)); // Red
        }
    }
}