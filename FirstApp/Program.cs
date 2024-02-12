using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class BaseDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public BaseDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public virtual string GetFormat()
        {
            return $"год:{Year}, месяц:{Month:00}, день:{Day:00}";
        }
    }

    public class AmericanDate : BaseDate
    {
        public AmericanDate(int year, int month, int day) : base(year, month, day) { }
        public override string GetFormat()
        {
            return $"{Month:00}.{Day:00}.{Year}";
        }
    }

    public class EuropeanDate : BaseDate
    {
        public EuropeanDate(int year, int month, int day) : base(year, month, day) { }
        public override string GetFormat()
        {
            return $"{Day:00}.{Month:00}.{Year}";
        }
    }

    class Program
    {
        static void Main()
        {
            BaseDate date = new BaseDate(2021, 3, 24);
            AmericanDate date1 = new AmericanDate(2021, 3, 24);
            EuropeanDate date2 = new EuropeanDate(2021, 3, 24);

            List<BaseDate> dates = new List<BaseDate>
            {
                date ,date1, date2
            };

            foreach (var item in dates)
            {
                Console.WriteLine(item.GetFormat());
            }
        }
    }
}