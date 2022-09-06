using P03AplikacjaZawodnicy;
using P05BibliotekaZawodnikVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy
{
    internal class ZawodnicyRepository
    {
        private string connString = "Data Source=.\\SQLEXPRESS;Initial Catalog=A_Zawodnicy;Integrated Security=True";

        public ZawodnikVM[] WczytajZawodnikow(string filtr, string sortowanie)
        {
            ModelBazyDanychDataContext db =new ModelBazyDanychDataContext();
            var zapytanie = db.Zawodnik.Where(x => 
                x.kraj.Contains(filtr) ||
                x.imie.Contains(filtr) ||
                x.nazwisko.Contains(filtr));

            if (!string.IsNullOrEmpty(sortowanie))
            {
                if (sortowanie == "imie")
                    zapytanie = zapytanie.OrderBy(x => x.imie);
                if (sortowanie == "nazwisko")
                    zapytanie = zapytanie.OrderBy(x => x.nazwisko);
                if (sortowanie == "wzrost")
                    zapytanie = zapytanie.OrderBy(x => x.imie);
            }

            Zawodnik[] zawodnicyDb = zapytanie.ToArray();
            var wynik =
                zawodnicyDb.Select(x => new ZawodnikVM()
                {
                    Imie = x.imie,
                    Nazwisko = x.nazwisko,
                    Kraj = x.kraj,
                    DataUr = x.data_ur,
                    Waga = x.waga == null ? 0 : (int)x.waga,
                    Wzrost = x.wzrost == null ? 0 : (int)x.wzrost,
                    Miasto = x.miasto,
                    Id_trenera = x.id_trenera,
                    Id_zawodnika = x.id_zawodnika
                }).ToArray();
            return wynik;
        }



        public void EdytujZawodnika(ZawodnikVM z)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Zawodnik doEdycji =
                db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == z.Id_zawodnika);
            doEdycji.imie = z.Imie;
            doEdycji.nazwisko = z.Nazwisko;
            doEdycji.kraj = z.Kraj;
            doEdycji.data_ur = z.DataUr;
            doEdycji.wzrost = z.Wzrost;
            doEdycji.waga = z.Waga;
            doEdycji.miasto = z.Miasto;
            db.SubmitChanges();

        }

        internal void DodajZawodnika(ZawodnikVM zawodnik)
        {

            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Zawodnik doDodania = new Zawodnik()
            {
                imie = zawodnik.Imie,
                nazwisko = zawodnik.Nazwisko,
                kraj = zawodnik.Kraj,
                data_ur = zawodnik.DataUr,
                wzrost = zawodnik.Wzrost,
                waga = zawodnik.Waga,
                miasto = zawodnik.Miasto
            };
            db.Zawodnik.InsertOnSubmit(doDodania);
            db.SubmitChanges();

        }

        public void UsunZawodnika(ZawodnikVM zawodnik)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Zawodnik doUsuniecia =
                db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == zawodnik.Id_zawodnika);

            db.Zawodnik.DeleteOnSubmit(doUsuniecia);
            db.SubmitChanges();
            
        }
    }
}
