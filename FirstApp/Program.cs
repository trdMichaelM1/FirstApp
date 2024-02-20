using System;

namespace CSharpEssentials
{

    class Program
    {
        public static int FindOccurrencesCount<T>(T[] array, T item)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                    count++;
            }
            return count;
        }
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 2, 4, 2 };
            int occurrences = FindOccurrencesCount(numbers, 2);
            Console.WriteLine(occurrences);   // 3

            string[] names = { "Josef", "Vadim", "Josef", "Ivan" };
            int occurrences2 = FindOccurrencesCount(names, "Josef");
            Console.WriteLine(occurrences2);  // 2
        }
    }
}