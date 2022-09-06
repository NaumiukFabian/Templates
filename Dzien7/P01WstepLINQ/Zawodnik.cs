using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01WstepLINQ
{
    internal class Zawodnik : ZawodnikBaza
    {
        public int Id_zawodnika { get; set; }
        public int Id_trenera { get; set; }
        
        public DateTime DataUr { get; set; }
        public int Wzrost { get; set; }
        public int Waga { get; set; }
        public string Miasto { get; set; }
        public int Temp { get; set; }
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
        
    }
}
