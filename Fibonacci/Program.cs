using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Fibonacci numbers you want to generate: ");
            int n = int.Parse(Console.ReadLine());

            int[] fibonacci = new int[n];

            int a0 = 0;
            int a1 = 1;

            for (int i = 0; i < n; i++)
            {
                int a = a0 + a1;
                fibonacci[i] = a;

                a0 = a1;
                a1 = a;
            }

            Console.WriteLine(string.Join(" ", fibonacci));
        }
    }
}
