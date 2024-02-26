using System;
using System.Collections;
using System.Collections.Generic;

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

    public class Entrance : IEnumerable<Flat>, IEnumerator<Flat>
    {
        private readonly Flat[] flats;
        private int index = -1;

        public Entrance(Flat[] flats)
        {
            this.flats = flats;
        }

        public Flat Current => flats[index];

        object IEnumerator.Current => flats[index];


        public IEnumerator<Flat> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            index++;
            return index < flats.Length;
        }

        public void Reset()
        {
            index = -1;
        }

        public void Dispose() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var entrance = new Entrance(new Flat[]
            {
                new Flat
                {
                    Number = 1,
                    RoomsCount = 2
                },
                new Flat
                {
                    Number = 2,
                    RoomsCount = 3
                },
                new Flat
                {
                    Number = 26,
                    RoomsCount = 1
                },
            });

            foreach (var item in entrance)
            {
                Console.WriteLine(item.Number);
            }
        }
    }
}