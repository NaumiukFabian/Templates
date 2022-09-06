using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P02AplikacjaZawodnicy
{
    public class TrenerVM
    {
        public int Id_trenara;
        public string Imie_trenera { get; set; }
        public string Nazwisko_trenera { get; set;}
        public DateTime? Data_ur_trenera { get; set;}

    }
}