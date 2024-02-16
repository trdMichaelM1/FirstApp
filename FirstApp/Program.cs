using System;

namespace CSharpEssentials
{
    public class Person
    {
        public int Age { get; set; }
        public static int LegalAge { get; set; } = 18;
        public Person(int age)
        {
            Age = age;
        }

        public static void IncreaseLegalAge(int age)
        {
            LegalAge += age;
        }

        public bool IsAdult()
        {
            return Age >= LegalAge;
        }
    }
    
    class Program
    {
        static void Main()
        {
            Person pers = new Person(18);
            if (pers.IsAdult())
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            } // YES

            Person.IncreaseLegalAge(1);
            if (pers.IsAdult())
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            } // NO  
        }
    }
}