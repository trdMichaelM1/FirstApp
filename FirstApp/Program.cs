using System;
using System.Collections;

namespace CSharpEssentials
{
    public class Flat
    {
        public int Number { get; set; }
        public int RoomsCount { get; set; }

        public override string ToString()
        {
            return $"Квартира с номером {Number} имеет {RoomsCount} комнат";
        }
    }

    public class Entrance
    {
        private readonly Flat[] flats;
        private int idx = -1;

        public Entrance(Flat[] flats)
        {
            this.flats = flats;
        }

        public Flat Current => flats[idx];

        public Entrance GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            idx++;
            return idx < flats.Length;
        }

        public void Reset()
        {
            idx = -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}