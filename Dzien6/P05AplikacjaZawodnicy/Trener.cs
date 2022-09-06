using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05AplikacjaZawodnicy
{
    public class Trener
    {
        public int Id_trenra;
        public string Imie;
        public string Nazwisko;
        public DateTime DataUrd;

        public string WidoczneDane
        {
            get
            {
                
                 return Id_trenra + " " + Imie + " " + Nazwisko + " " + DataUrd;
            }
        }

    }
}
