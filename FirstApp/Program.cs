using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    class Program
    {
        public static void Reverse<T>(List<T> list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                T temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }

        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Reverse(numbers);
            Console.WriteLine(string.Join(", ", numbers));  // 5, 4, 3, 2, 1

            List<string> names = new List<string> { "Josef", "Vadim", "Ivan" };
            Reverse(names);
            Console.WriteLine(string.Join(", ", names));  // Ivan, Vadim, Josef
        }
    }
}