using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02WstepORM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            Zawodnik[] wynik1 = db.Zawodnik.Where(x => x.kraj == "pol").ToArray();
            foreach(var wynik in wynik1)
            {
                Console.WriteLine(wynik.imie + " " + wynik.nazwisko);
            }

            //dodwania nowych rekordow
            //Zawodnik nowy = new Zawodnik()
            //{
            //    imie = "Jan",
            //    nazwisko = "Kowalski",
            //    kraj = "pol",
            //    data_ur = DateTime.Now,
            //    wzrost = 180,
            //    waga = 80
            //};

            //db.Zawodnik.InsertOnSubmit(nowy);
            //db.SubmitChanges();

            //edycja
            //najpier pobieramy zawodnika ktorego chcemy edytowac
            //zmieniamy odpowiednie pola
            //zapisujemy zmiany

            //Zawodnik doEdycji = db.Zawodnik.Where(x => x.id_zawodnika == 35).ToArray()[0];

            //Zawodnik doEdycji = db.Zawodnik.Where(x => x.id_zawodnika == 35).FirstOrDefault();

            //Zawodnik doEdycji = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == 35);

            //doEdycji.nazwisko = "nowak";
            //db.SubmitChanges();

            //usuwanie 
            Zawodnik doUsuniecia = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == 35);

            db.Zawodnik.DeleteOnSubmit(doUsuniecia);
            db.SubmitChanges();

            Console.ReadKey();
        }
    }
}
