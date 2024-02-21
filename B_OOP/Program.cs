using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_OOP
{
    public class A
    {
        public int X;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x =3;
            object obj = x;

            bool isInt = obj is int;
            if (isInt)
                Console.WriteLine((int)obj);

            A a = new A();
            object obj2 = a;

            A a1 = obj2 as A;
        }

        static void NullFoo()
        {
            int? i = null;
            i = i.GetValueOrDefault();
            Console.WriteLine(i.Value);

            Console.ReadLine();

            A a1 = null;
            Console.WriteLine(a1?.X);

            Console.ReadLine();

            A a = null;

            //A b = a ?? throw new ArgumentNullException(nameof(a));

            Console.ReadLine();

            int x = 5;
            int y = 10;

            Console.WriteLine($"x={x} y={y}");
            // Передаем значения значимового типа по ссылке используя ref
            Swap(ref x, ref y);
            Console.WriteLine($"x={x} y={y}");
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
