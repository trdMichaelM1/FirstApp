using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual string GetInfo()
        {
            return $"Имя: {Name}, Возраст: {Age}";
        }
    }

    public class Student : Person
    {
        public int Course { get; set; }
        public string Profession { get; set; }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Курс: {Course}, Специальность: {Profession}";
        }

    }
    public class ProgrammingStudent : Student
    {
        public string ProgrammingLanguage { get; set; }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, язык программирования: {ProgrammingLanguage}";
        }
    }

    public class Professor : Person
    {
        public string Subject { get; set; }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}, предмет: {Subject}";
        }
    }

    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            people.Add(new Student() { Name = "Student1", Age = 21, Course = 1, Profession = "C#" });
            people.Add(new Professor() { Name = "Professor1", Age = 51, Subject = "Матан" });
            people.Add(new ProgrammingStudent() { Name = "ProgrammingStudent1", Age = 22, Course = 2, Profession = "ЯП", ProgrammingLanguage = "C#" });

            foreach (var person in people)
            {
                Console.WriteLine(person.GetInfo());
            }
        }
    }
}