using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class Profile
    {
        public string Occupation { get; set; }

        public Profile(string occupation)
        {
            Occupation = occupation;
        }

        protected virtual string GetInfo()
        {
            return string.Empty;
        }

        public void Describe()
        {
            Console.WriteLine($"{Occupation}, {GetInfo()}");
        }
    }

    public class Vacancy : Profile
    {
        public int Salary { get; set; }

        public Vacancy(string occupation, int salary) : base(occupation)
        {
            Salary = salary;
        }

        protected override string GetInfo()
        {
            return $"Предлагаемая зарплата: {Salary}";
        }
    }

    public class Resume : Profile
    {
        public int WorkExperience { get; set; }

        public Resume(string occupation, int workExperience) : base(occupation)
        {
            WorkExperience = workExperience;
        }

        protected override string GetInfo()
        {
            return $"Стаж работы: {WorkExperience}";
        }
    }

    class Program
    {
        static void Main()
        {
            List<Profile> profiles = new List<Profile>
            {
                new Vacancy("C# разработчик", 100000),
                new Vacancy("Python разработчик", 90000),
                new Vacancy("C++ разработчик", 110000),
                new Resume("C# разработчик", 4),
                new Resume("C++ разработчик", 1),
            };

            foreach (var profile in profiles)
            {
                profile.Describe();
            }
        }
    }
}