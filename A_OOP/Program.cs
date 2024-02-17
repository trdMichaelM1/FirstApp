using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_OOP
{
    public class Calculator
    {
        public double Average(int[] numbers)
        {
            double sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;
        }

        public double Average2(params int[] numbers)
        {
            double sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Calculator calculator = new Calculator();
                double avg = calculator.Average(new int[] { 1, 2, 3, 4 });
                avg = calculator.Average2(1, 2, 3, 4);
                Console.WriteLine(avg);

                string line = Console.ReadLine();
                bool wasParse = int.TryParse(line, out int number);
                if (wasParse)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
