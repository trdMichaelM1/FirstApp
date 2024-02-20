using System;
using System.Diagnostics;
using System.Text;

namespace CSharpEssentials
{
    class Program
    {
        private delegate void MeasureMethod(int repeatCount);
        private static void Main()
        {
            //MeasureMethod method = MeasureString;
            //Measure(method);
            Measure(MeasureString);
            //method = MeasureStringBuilder;
            //Measure(method);
            Measure(MeasureStringBuilder);
        }

        private static void Measure(MeasureMethod method)
        {
            int repeatCount = 10000;
            Stopwatch time = Stopwatch.StartNew();
            //method(repeatCount);
            method?.Invoke(repeatCount);
            time.Stop();
            Console.WriteLine(time.Elapsed.TotalMilliseconds);
        }

        private static void MeasureStringBuilder(int repeatCount)
        {
            StringBuilder stringBuilderResult = new StringBuilder("Test");
            for (int i = 0; i < repeatCount; i++)
            {
                stringBuilderResult.Append($"{i}");
            }
        }

        private static void MeasureString(int repeatCount)
        {
            string stringResult = "Test";
            for (int i = 0; i < repeatCount; i++)
            {
                stringResult += $"{i}";
            }
        }
    }
}