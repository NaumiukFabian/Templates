using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy
{
    internal class ManagerPogody
    {
        private string urlSzablon = "https://www.google.com/search?q=pogoda+";
        const char znakSzukany = '°';
        const char znakKoncowy = '>';
        public int Temperatura(Zawodnik zawodnik, string[] daneMiasta)
        {
            return 0;

            string miasto = zawodnik.Miasto;
            string url = urlSzablon + miasto;

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(url);
            int indx = dane.IndexOf(znakSzukany);
            int aktualnaPozycja = indx;

            while (dane[aktualnaPozycja] != znakKoncowy)
            {
                aktualnaPozycja--;
            }
            int dlugosc = indx - aktualnaPozycja;
            string wynik = dane.Substring(aktualnaPozycja + 1, dlugosc + 1 - 2);
            zawodnik.Temp = Convert.ToInt32(wynik);
            return zawodnik.Temp;

        }
    }
}
