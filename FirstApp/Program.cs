using System;

namespace CSharpEssentials
{
    public struct Money
    {
        public int Ruble { get; set; }
        private int _kopech;
        public int Kopeck
        {
            get
            {
                return _kopech;
            }
            set
            {
                if (value < 0 || value > 99)
                    throw new Exception();
                _kopech = value;
            }
        }

        public Money(int ruble, int kopeck)
        {
            _kopech = 0;
            Ruble = ruble;
            Kopeck = kopeck;
        }

        public override string ToString()
        {
            return $"{Ruble}, {Kopeck:00}";
        }

        public static Money operator +(Money a, Money b)
        {
            int rub = (a.Ruble * 100 + a.Kopeck) + (b.Ruble * 100 + b.Kopeck);
            return new Money(rub / 100, rub % 100);
        }

        public static Money operator -(Money a, Money b)
        {
            int rub = (a.Ruble * 100 + a.Kopeck) - (b.Ruble * 100 + b.Kopeck);
            return new Money(rub / 100, Math.Abs(rub % 100));
        }
    }
    class Program
    {
        static void Main()
        {
            //Money money1 = new Money(10, 50);
            //Console.WriteLine(money1); // 10, 50

            //money1.Ruble = 4;
            //money1.Kopeck = 5;
            //Console.WriteLine(money1); // 4, 05

            //money1.Kopeck = 100; // ошибка

            Money money1 = new Money(11, 51);
            Money money2 = new Money(25, 90);

            Money money3 = money1 + money2;
            Console.WriteLine(money3); // 37, 41

            Money money4 = money3 - money2;
            Console.WriteLine(money4); // 11, 51

            Money money5 = money1 - money2;
            Console.WriteLine(money5); // -14, 39
        }
    }
}