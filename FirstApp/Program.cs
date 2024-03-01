using System;
using System.IO;
using System.Text;

namespace CSharpEssentials
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            try
            {
                Console.WriteLine(1 / a);
            }
            catch (Exception)
            {
                Console.WriteLine(2);
            }
            finally
            {
                Console.WriteLine(3);
            }
        }

    }
}