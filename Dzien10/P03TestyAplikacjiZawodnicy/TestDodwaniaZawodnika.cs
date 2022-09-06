using Microsoft.VisualStudio.TestTools.UnitTesting;
using P06Powtorzenie;
using P05BibliotekaZawodnikVM;
using System;

namespace P03TestyAplikacjiZawodnicy
{
    [TestClass]
    public class TestDodwaniaZawodnika
    {
        [TestMethod]
        public void Scenariusz1()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            ZawodnikVM zvm = new ZawodnikVM()
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Kraj = "pol",
                Miasto = "Warszawa",
                DataUr = DateTime.Now,
                Waga = 85,
                Wzrost = 185
            };

            int ile = zr.WczytajZawodnikow("", null).Length;

            zr.DodajZawodnika(zvm);

            int oczekujemy = ile + 1;

            int aktualnie = zr.WczytajZawodnikow("", null).Length;

            Assert.AreEqual(oczekujemy, aktualnie);
        }
    }
}
