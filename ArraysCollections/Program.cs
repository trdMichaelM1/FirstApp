using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { };

            Array myArray = new int[] { 1, 2 };
            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            myArray2.SetValue(12, 0);
            Console.WriteLine(myArray2.GetValue(0));
        }
    }
}
