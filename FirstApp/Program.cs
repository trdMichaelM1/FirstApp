using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    class Program
    {
        delegate bool Predicate(int number);
        private static void Main()
        {
            List<int> years = new List<int> { 13, 17, 18, 19, 20, 50 };
            List<int> adults = GetAdults(years, IsAdult);

            foreach (var adult in adults)
            {
                Console.WriteLine(adult);
            }
        }

        static bool IsAdult(int age)
        {
            if (age >= 18)
                return true;
            return false;
        }

        static List<int> GetAdults(List<int> list, Predicate predicate)
        {
            List<int> result = new List<int>();
            foreach (int item in list)
            {
                if (predicate(item))
                    result.Add(item);
            }
            return result;
        }
    }
}