using System;

namespace CSharpEssentials
{    
    public static class StringHelpers
    {
        public static int CountWords(this string s)
        {
            s = s.Replace("-", " ");
            string[] words = s.Split(new char[] { ' ', '.', '?', '!', ':' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
    class Program
    {
        static void Main()
        {
            var sentence = "Я люблю программировать! Я стану великим программистом.";

            var wordsCount = sentence.CountWords();

            Console.WriteLine(wordsCount);
        }
    }
}