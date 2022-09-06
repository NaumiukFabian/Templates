using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01WstepLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] napisy = { "BACHLEDA", "MATEJA", "HERR" };

            string[] wynik = napisy.Where(x => x.Length > 4).ToArray();

            //Console.WriteLine(string.Join(" ", wynik));
            int[] liczby = { 4, 6, 2, 31, 12, 2 };
            int[] wynik2 = liczby
                .Where(x => x > 10)
                .OrderBy(x => x)    
                .ToArray();

            ManagerZawodnikow mz = new ManagerZawodnikow();
            string[] wiersze = File.ReadAllLines(@"C:\Dane\zawodnicy.txt");
            Zawodnik[] zrodlo = mz.Wczytaj(wiersze);


            //Zawodnik[] wynik3 = zrodlo.Where(x => x.Kraj == "POL").ToArray();
            Zawodnik[] wynik4 = zrodlo
                .Where(x => x.Nazwisko.ToLower().EndsWith("a") && x.Wzrost > 2*(x.Waga) && x.DataUr.Month > 6)
                .OrderBy(x => x.Imie.Length)
                .ToArray();

            //foreach(var z in wynik3)
            //{
            //    Console.WriteLine(z.Imie + " " + z.Nazwisko);
            //}

            wynik4
                .ToList()
                .ForEach(x => 
                { 
                    Console.WriteLine(x.Imie + " " + x.Nazwisko + " " + x.DataUr); 
                });

            string[] wynik5 = zrodlo
                .Where(x => x.Nazwisko.ToLower().EndsWith("a") && x.Wzrost > 2 * (x.Waga) && x.DataUr.Month > 6)
                .OrderBy(x => x.Imie.Length)
                .Select(x => x.Imie + " " + x.Nazwisko + " " + x.Kraj)
                .ToArray();

            string[] wynik6 =
                zrodlo
                .Select(x => x.Kraj)
                .OrderBy(x => x)
                .ToArray();

            string[] wynik7 =
                zrodlo
                .OrderBy(x => x.Kraj)
                .Select(x => x.Kraj)
                .ToArray();

            ZawodnikMini[] wynik8 = zrodlo.Select(x => new ZawodnikMini()
            {
                Imie = x.Imie,
                Nazwisko = x.Nazwisko,
                Kraj = x.Kraj,
                BMI = x.Waga / Math.Pow(Convert.ToDouble(x.Wzrost) / 100, 2)
            }).ToArray();

            var wynik10 = 
            zrodlo.Select(x => new
            {
                MojeImie = x.Imie,
                MojeNazwisko = x.Nazwisko,
                Wspolczynnik = x.Wzrost + x.Waga
            }).ToArray();

            var wynik11 = zrodlo.GroupBy(x => x.Kraj).Select(x => new { kraj = x.Key, srWzrost = x.Average(y => y.Wzrost) }).ToArray();

            
        

            Console.ReadLine();


        }
    }
}
