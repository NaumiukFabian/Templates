using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy
{
    public class ManagerZawodnikow
    {

        private string kraj;
        public double sredniaTemperatura;
        public double sredniaTemperaturaAll;
        private Zawodnik[] wczytaniZawodnicy;
        private Zawodnik[] wszyscyZawodnicy;
        private string sciezka;
        private Sortowanie kierunekSortowanie;
        public Sortowanie KierunekSortowania => kierunekSortowanie;

        public Zawodnik[] WczytaniZawodnicy => wczytaniZawodnicy;

        public ManagerZawodnikow(string kraj, string sciezka)
        {
            this.kraj = kraj;
            this.sciezka = sciezka;
        }

        public Zawodnik[] Wczytaj(string[] wiersze)
        {

            List<Zawodnik> zawodnicy = new List<Zawodnik>();
            wszyscyZawodnicy = new Zawodnik[wiersze.Length - 1];
            ManagerPogody mp = new ManagerPogody();
            int sumaTemperatur = 0;
            int sumaTemperaturAll = 0;
            int iloscRekordow = 0;
            int iloscWszystkichRekordow = 0;
            


            for(int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');

                iloscWszystkichRekordow++;

                Zawodnik z = new Zawodnik(komorki, this);
                sumaTemperaturAll = sumaTemperaturAll + mp.Temperatura(z, komorki);
                if (kraj.ToLower() == z.Kraj.ToLower())
                {
                    sumaTemperatur = sumaTemperatur + mp.Temperatura(z, komorki);
                    zawodnicy.Add(z);
                    iloscRekordow++;
                }

                wszyscyZawodnicy[i - 1] = z;
                
            }

            sredniaTemperatura = sumaTemperatur / (double)iloscRekordow;
            sredniaTemperaturaAll = sumaTemperaturAll / (double)iloscWszystkichRekordow;

            wczytaniZawodnicy = zawodnicy.ToArray();
            return wczytaniZawodnicy;
            //return zawodnicy.ToArray();

        }

        internal void StowrzNowego(Zawodnik zawodnik)
        {
            List<Zawodnik> wszyscyZawodnicyLista = wszyscyZawodnicy.ToList();
            wszyscyZawodnicyLista.Add(zawodnik);
            wszyscyZawodnicy = wszyscyZawodnicyLista.ToArray();

            if (zawodnik.Kraj.ToLower() == kraj.ToLower())
            {
                List<Zawodnik> wczytaniZawodnicyLista = wczytaniZawodnicy.ToList();
                wczytaniZawodnicyLista.Add(zawodnik);
                wczytaniZawodnicy = wszyscyZawodnicyLista.ToArray();
            }
        }

        public string SredniaTemperaturaDanegKraju()
        {
            string srTempPopr = String.Format("{0:N2}", sredniaTemperatura);
            return srTempPopr;
        }

        public string SredniaTemperaturaWszystkichRekordow()
        {
            string srTempPoprAll = String.Format("{0:N2}", sredniaTemperaturaAll);
            return srTempPoprAll;
        }

        public void Edytuj(Zawodnik z)
        {
            for(int i = 0; i < wczytaniZawodnicy.Length; i++)
                if (z.Id_zawodnika == wczytaniZawodnicy[i].Id_zawodnika)
                    wczytaniZawodnicy[i] = z;

            for (int i = 0; i < wszyscyZawodnicy.Length; i++)
                if (z.Id_zawodnika == wszyscyZawodnicy[i].Id_zawodnika)
                    wszyscyZawodnicy[i] = z;

        }

        internal void Sortuj(Sortowanie sortowanie)
        {
            kierunekSortowanie = sortowanie;
            Array.Sort(wczytaniZawodnicy);
            Array.Sort(wszyscyZawodnicy);
        }

        public void Zapisz()
        {
            string plik = "id_zawodnika;id_trenera;imie;nazwisko;kraj;data urodzenia;wzrost;waga;miasto;temp" + Environment.NewLine;

            foreach(var z in wszyscyZawodnicy)
            {
                plik += z.Wiersz + Environment.NewLine;
            }
            File.WriteAllText(sciezka,plik);
        }

        public void Usun(Zawodnik z)
        {
            List<Zawodnik> wszyscyZawodnicyLista = wszyscyZawodnicy.ToList();
            wszyscyZawodnicyLista.Remove(z);
            wszyscyZawodnicy= wszyscyZawodnicyLista.ToArray();

            if(z.Kraj.ToLower() == kraj.ToLower())
            {
                List<Zawodnik> wczytaniZawodnicyLista = wczytaniZawodnicy.ToList();
                wczytaniZawodnicyLista.Remove(z);
                wczytaniZawodnicy= wczytaniZawodnicyLista.ToArray();
            }
        }
    }
}
