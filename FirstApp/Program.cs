using System;
using System.Collections.Generic;

namespace Stepik
{
    public class School
    {
        public List<Student> Students;

        public int Count(Func<Student, bool> filter)
        {
            int count = 0;
            foreach (Student student in Students)
            {
                if(filter(student))
                    count++;
            }
            return count;
        }
    }

    public class Student
    {
        public readonly string FIO;
        public readonly int Grade;
        public readonly double Performance;

        public Student(string fio, int grade, double performance)
        {
            FIO = fio;
            Grade = grade;
            Performance = performance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            school.Students = new List<Student>()
            {
                new Student("Багаев Аслан", 10, 4.3),
                new Student("Абаев Георгий", 8, 5),
                new Student("Дзуцев Михаил", 2, 3.8),
                new Student("Елоев Сармат", 11, 4.6)
            };
            Console.WriteLine(school.Count(x => x.Grade > 2)); // 3
            Console.WriteLine(school.Count(x => x.FIO.Contains("Багаев"))); // 1
        }
    }
}