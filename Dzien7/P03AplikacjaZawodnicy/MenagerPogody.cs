using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy
{

    enum Jednostka
    {
        Celcjusz,
        Fahrenheit,
        Kelvin
    }
    internal class MenagerPogody
    {
        //properties = właściwości - cechy obiektu (rozbudowane o get set)
        //fields = pola - to samo co właściwości bez get set
        //methods = metody - co dana klasa potrafi zribic
        //constructor = konstruktory - funkcja ktora wywoluje podczas tworzenie obiektu

        const string urlSzablon = "https://www.google.com/search?q=pogoda+";
        const char znakSzuakny = '°';
        const char znakKoncowy = '>';
        Jednostka jednostka;

        public MenagerPogody(Jednostka jednostka)
        {
            this.jednostka = jednostka;
        }

        /// <summary>
        /// Pobiera temperaturę z seriwsu GOOGLE 
        /// </summary>
        /// <param name="nazwaMiasta">Nazwa miasta dla którego chcesz znaleźć temperaturę</param>
        /// <returns>Zwraca temperatruę w stropniach Celcjusza</returns>
        public double PodajTemperature(string nazwaMiasta)
        {
            
            string url = urlSzablon + nazwaMiasta;

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(url);
            
            int indx = dane.IndexOf(znakSzuakny);

            if (indx == -1)
                throw new Exception("Nie znaleziono znaku końcowego °");

            int aktualnaPozycja = indx;
           
            while (dane[aktualnaPozycja] != znakKoncowy)
            {
                aktualnaPozycja--;
            }
            int dlugosc = indx - aktualnaPozycja;
            string wynik = dane.Substring(aktualnaPozycja + 1, dlugosc + 1 - 2);
            return transformuj(Convert.ToInt32(wynik));

        }


        private double transformuj(int temp)
        {
            if (jednostka == Jednostka.Celcjusz)
                return temp;
            if (jednostka == Jednostka.Fahrenheit)
                return (temp*1.8)+23;
            if (jednostka == Jednostka.Kelvin)
                return temp+273.15;

            throw new Exception("Nieznana jednostka");
        }
    }
}
