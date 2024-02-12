using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class Player
    {
        public string Name { get; }
        public int Number { get; }
        public Player(string name, int number)
        {
            Name = name;
            Number = number;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            Player player = (Player)obj;

            return player.Name.Equals(Name) && player.Number.Equals(Number);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Number.GetHashCode();
        }
    }

    class Program
    {
        static void Main()
        {
            Player player1 = new Player("Sergio Ramos", 4);
            Player player2 = new Player("Sergio Ramos", 4);
            Console.WriteLine(player1.Equals(player2));
            Console.WriteLine(player1.GetHashCode() == player2.GetHashCode());

        }
    }
}