using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy
{
    internal class TrenerRepository
    {

        public TrenerVM[] WczytajTrenera()
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            var zapytanie = from row in db.Trener select row;
            Trener[] trenerzy = zapytanie.ToArray();
            var wynik =
                 trenerzy.Select(x => new TrenerVM()
                 {
                     Id_trenra = x.id_trenera,
                     Imie = x.imie_t,
                     Nazwisko = x.nazwisko_t,
                     DataUrd = x.data_ur_t
                 }).ToArray();

            return wynik;

        }

        public void EdytujTrenera(TrenerVM z)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Trener trenerDoEdycji =
                db.Trener.FirstOrDefault(x => x.id_trenera == z.Id_trenra);
            trenerDoEdycji.imie_t = z.Imie;
            trenerDoEdycji.nazwisko_t = z.Nazwisko;
            trenerDoEdycji.data_ur_t = z.DataUrd;
            db.SubmitChanges();
        }

        public void DodajTrenera(TrenerVM z)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Trener nowyTrener = new Trener()
            {
                imie_t = z.Imie,
                nazwisko_t = z.Nazwisko,
                data_ur_t = z.DataUrd
            };
            db.Trener.InsertOnSubmit(nowyTrener);
            db.SubmitChanges();
        }

        public void UsunTrenera(TrenerVM z)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Trener trenerUsun =
                db.Trener.FirstOrDefault(x => x.id_trenera == z.Id_trenra);
            db.Trener.DeleteOnSubmit(trenerUsun);
            db.SubmitChanges();

        }
    }
}
