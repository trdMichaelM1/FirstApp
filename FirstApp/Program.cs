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

    public class Entrance : IEnumerable
    {
        private readonly Flat[] flats;

        public Entrance(Flat[] flats)
        {
            this.flats = flats;
        }

        public IEnumerator GetEnumerator()
        {
            return new EntranceEnumerator(flats);
        }
    }

    public class EntranceEnumerator : IEnumerator
    {
        private readonly Flat[] flats;
        private int idx = -1;

        public EntranceEnumerator(Flat[] flats)
        {
            this.flats = flats;
        }

        public object Current => flats[idx];

        public bool MoveNext()
        {
            idx++;
            if (idx >= flats.Length)
                return false;
            return true;
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