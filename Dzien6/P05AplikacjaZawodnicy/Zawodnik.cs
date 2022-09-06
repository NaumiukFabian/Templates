using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05AplikacjaZawodnicy
{
    public class Zawodnik
    {
        public int Id_zawodnika { get; set; }
        public int Id_trenera { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Kraj { get; set; }
        public DateTime? DataUr { get; set; }
        public int Wzrost { get; set; }
        public int Waga { get; set; }
        public string Miasto { get; set; }
        public int Temp { get; set; }

        public string DataUrSQL
        {
            get
            {
                if (DataUr == null)
                    return "null";

                return $"'{((DateTime)DataUr).ToString("yyyyMMdd")}'";
            }
        }

        public string WidoczneDane
        {
            get
            {
                return Imie + " " + Nazwisko + " " + Kraj + " " + Miasto;
            }
        }

        public string WidoczneDaneDwa
        {
            get
            {
                return Imie + " " + Miasto + " " + Temp + "°C";
            }
        }

        public string Wiersz
        {
            get
            {
                return $"{Id_zawodnika};{Id_trenera};{Imie};{Nazwisko};{Kraj};{DataUr?.ToString("yyyy-MM-dd")};{Wzrost};{Waga};{Miasto};{Temp}";
            }
        }

        public Zawodnik(string[] komorki)
        {
            Id_zawodnika = Convert.ToInt32(komorki[0]);
            Id_trenera = Convert.ToInt32(komorki[1]);
            Imie = komorki[2];
            Nazwisko = komorki[3];
            Kraj = komorki[4];
            DataUr = Convert.ToDateTime(komorki[5]);
            Wzrost = Convert.ToInt32(komorki[6]);
            Waga = Convert.ToInt32(komorki[7]);
            Miasto = komorki[8];
        }

        public Zawodnik()
        {

        }

        //public int CompareTo(object obj)
        //{
        //    Zawodnik z = (Zawodnik)obj;

        //    if (mz.KierunekSortowania == Sortowanie.Nazwisko)
        //        return string.Compare(Nazwisko, z.Nazwisko);
        //    else if (mz.KierunekSortowania == Sortowanie.Imie)
        //        return string.Compare(Imie, z.Imie);
        //    else if (mz.KierunekSortowania == Sortowanie.Wzrost)
        //        return Wzrost - z.Wzrost;

        //    throw new Exception("Nieznany kierunek sortowania");


        //}
    }
}
