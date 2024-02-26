using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName;

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName;

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class School
    {
        public string Name;
        public List<Student> Students;

        public School(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void PrintStudents()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine($"School \"{Name}\" does not have any students!");
                return;
            }

            Console.WriteLine($"{"First Name",-10} {"Last Name",-10}");
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine($"{Students[i].FirstName,-10} {Students[i].LastName,-10}");
            }
        }

        public void AddNewStudent(Student student)
        {
            Students.Add(student);
            Console.WriteLine($"The student \"{student.FirstName}\" successfully added to school \"{Name}\"");
        }
    }

    internal class Program
    {
        static bool YesOrNoQuestion()
        {
            string userAnswer = Console.ReadLine();
            userAnswer = userAnswer.Trim().ToLower();
            if (userAnswer == "y")
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Hello! Enter school's name: ");
            string schoolName = Console.ReadLine();

            School school = new School(schoolName);
            Console.WriteLine($"School \"{school.Name}\" successfully created!");

            while (true)
            {
                Console.WriteLine($"Do you want to look at the list of the students \"{school.Name}\" school? y/n");
                if (YesOrNoQuestion())
                {
                    school.PrintStudents();
                }

                Console.WriteLine($"Do you want to add a new student at school \"{school.Name}\"? y/n");
                if (YesOrNoQuestion())
                {
                    Console.WriteLine("Name of student:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Last name of student:");
                    string lastName = Console.ReadLine();

                    Student student = new Student(firstName, lastName);
                    school.AddNewStudent(student);
                }
            }
        }
    }
}
