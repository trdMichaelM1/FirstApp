using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    class Program
    {
        static void Main()
        {
            Func<int, bool> predicate = item =>
            {
                return item * item % 10 == 9 ? true : false;
            };

            Print(new List<int> { 1, 2, 3, 4, 5, 7, 13, 27 }, predicate);
        }

        static void Print(List<int> items, Func<int, bool> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}