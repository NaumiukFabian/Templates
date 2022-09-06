using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Interfejsy
{
    internal class Program
    {
        private class Krzeslo : IComparable
        {
            public int Wysokosc;
            public int Waga;
            public string Producent;

            public int CompareTo(object obj)
            {
                int naszaLiczbaznakow = Producent.Length;
                int inneKrzeslo = ((Krzeslo)obj).Producent.Length;
                return naszaLiczbaznakow - inneKrzeslo;
            }
        }



        static void Main(string[] args)
        {
            int[] liczby = {0,3,2,8,4,10,6};
            Array.Sort(liczby);
            string napis = string.Join(" ", liczby);
            Console.WriteLine(napis);

            Krzeslo[] krzesla = new Krzeslo[3]
            {
                new Krzeslo() { Waga = 30, Wysokosc = 50, Producent = "Xx" },
                new Krzeslo() { Waga = 20, Wysokosc = 40, Producent = "Yyyy" },
                new Krzeslo() { Waga = 10, Wysokosc = 30, Producent = "Z" }
            };

            Array.Sort(krzesla);

            foreach(var k in krzesla)
            {
                Console.WriteLine(k.Producent);
            }

            Console.ReadKey();


        }
    }
}
