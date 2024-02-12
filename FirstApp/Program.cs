using System;

namespace CSharpEssentials
{
    public class Student
    {
        public string Password { get; set; } = "Алоомора";

        public void Spell() { }
    }

    public class GriffindorStudent : Student
    {
        public new string Password { get; set; } = "Грата Домум";

        public void BreakRules() { }
    }

    public class SlytherinStudent : Student
    {
        public new string Password { get; set; } = "Чистая кровь";

        public void Cheat() { }
    }
    class Program
    {
        static void Main()
        {
            Student stud = new Student();
            Console.WriteLine(stud.Password);//Алоомора

            GriffindorStudent grifStud = new GriffindorStudent();
            grifStud.BreakRules(); //ничего не выводит
            Console.WriteLine(grifStud.Password); //Грата Домум
            Console.WriteLine(((Student)grifStud).Password); //Алоомора
        }
    }
}