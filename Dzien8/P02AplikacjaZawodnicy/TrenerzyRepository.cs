using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P02AplikacjaZawodnicy
{
    public class TrenerzyRepository
    {
        public TrenerVM[] WczytajTrenerow()
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            var trenerzy = from row in db.Trener select row;
            Trener[] wynikZapytania = trenerzy.ToArray();
            TrenerVM[] wynik = wynikZapytania.
                Select(x => new TrenerVM()
                {
                    Id_trenara = x.id_trenera,
                    Imie_trenera = x.imie_t,
                    Nazwisko_trenera = x.nazwisko_t,
                    Data_ur_trenera = x.data_ur_t
                }).ToArray();
            return wynik;
        }
    }
}