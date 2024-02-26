using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public interface IStudent
    {
        int Year { get; set; }
        void DoHomework();
    }

    public interface IWorker
    {
        int Salary { get; set; }
        void Work();
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Student : Person, IStudent, IWorker
    {
        public int Year { get; set; }
        public void DoHomework() { }
        public int Salary { get; set; }
        public void Work() { }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}