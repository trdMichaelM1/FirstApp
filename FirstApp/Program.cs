using System;
using System.IO;
using System.Text;

namespace CSharpEssentials
{
    public class Team
    {
        public string Name { get; set; } = "Gryffindor";
        public int Points { get; set; } = 0;

        public void PrintInfo()
        {
            Console.WriteLine($"{Name}:{Points}");
        }
    }

    public class Quidditch
    {
        public Team RedTeam = new Team();
        public Team BlueTeam = new Team();

        public void ShowScore()
        {
            Console.WriteLine($"{RedTeam.Name}:{RedTeam.Points}");
            Console.WriteLine($"{BlueTeam.Name}:{BlueTeam.Points}");
        }

        public void RedSnitch()
        {
            RedTeam.Points += 150;
            Console.WriteLine("Red Team Won!");
        }

        public void BlueSnitch()
        {
            BlueTeam.Points += 150;
            Console.WriteLine("Blue Team Won!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int size = sizeof(decimal);
            Console.WriteLine(size);
        }

    }
}