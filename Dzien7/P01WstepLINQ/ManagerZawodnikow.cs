using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P01WstepLINQ
{
    internal class ManagerZawodnikow
    {

        private string kraj;
        public ManagerZawodnikow()
        {

        }

        public ManagerZawodnikow(string kraj)
        {
            this.kraj = kraj;
        }

        public Zawodnik[] Wczytaj(string[] wiersze)
        {

            List<Zawodnik> zawodnicy = new List<Zawodnik>();
            


            for(int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');

                Zawodnik z = new Zawodnik(komorki);

                if (kraj == null || (kraj.ToLower() == z.Kraj.ToLower()))
                {
                    zawodnicy.Add(z);
                }
                
            }

            return zawodnicy.ToArray();

        }

    }
}
