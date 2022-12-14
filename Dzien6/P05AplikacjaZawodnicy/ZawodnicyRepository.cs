using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05AplikacjaZawodnicy
{
    internal class ZawodnicyRepository
    {
        private string connString = "Data Source=.\\SQLEXPRESS;Initial Catalog=A_Zawodnicy;Integrated Security=True";

        public Zawodnik[] WczytajZawodnikow(string filtr, string sortowanie)
        {
            string sql = $"select * from zawodnicy where kraj like '%{filtr}%'" +
                $"or imie like '${filtr}%' " +
                $"or nazwisko like '${filtr}%' ";

            if (sortowanie != null)
                sql += " order by " + sortowanie;

            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            object[][] wynik = pzb.WykonajZapytanie(sql);

            Zawodnik[] zawodnicy = new Zawodnik[wynik.Length];

            for (int i = 0; i < wynik.Length; i++)
            {
                Zawodnik ityZawodnik = new Zawodnik();

                ityZawodnik.Id_zawodnika = (int)wynik[i][0];
                ityZawodnik.Imie = (string)wynik[i][2];
                ityZawodnik.Nazwisko = (string)wynik[i][3];
                ityZawodnik.Kraj = (string)wynik[i][4];
                ityZawodnik.Wzrost = (int)wynik[i][6];
                ityZawodnik.Waga = (int)wynik[i][7];

                if (wynik[i][5] != DBNull.Value)
                {
                    ityZawodnik.DataUr = (DateTime)wynik[i][5];
                }

                if (wynik[i][8] != DBNull.Value)
                    ityZawodnik.Miasto = (string)wynik[i][8];

                zawodnicy[i] = ityZawodnik;
            }

            return zawodnicy;


        }



        public void EdytujZawodnika(Zawodnik z)
        {
            string sql = "update zawodnicy set imie='{0}', nazwisko='{1}', kraj='{2}', data_ur={3}, wzrost={4}, waga={5}, miasto='{6}' where id_zawodnika={7}";
            sql = string.Format(sql, z.Imie, z.Nazwisko, z.Kraj, z.DataUrSQL, z.Wzrost, z.Waga, z.Miasto, z.Id_zawodnika);

            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            pzb.WykonajZapytanie(sql);
        }

        internal void DodajZawodnika(Zawodnik zawodnik)
        {
            string sql = "insert into zawodnicy (imie, nazwisko, kraj, data_ur, wzrost, waga, miasto) values ('{0}', '{1}', '{2}', {3}, {4}, {5}, '{6}')";
            sql = string.Format(sql, zawodnik.Imie, zawodnik.Nazwisko, zawodnik.Kraj, zawodnik.DataUrSQL, zawodnik.Wzrost, zawodnik.Waga, zawodnik.Miasto);

            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            pzb.WykonajZapytanie(sql);
        }

        public void UsunZawodnika(Zawodnik zawodnik)
        {
            string sql = "delete zawodnicy where id_zawodnika = {0}";
            sql = string.Format(sql, zawodnik.Id_zawodnika);

            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            pzb.WykonajZapytanie(sql);
        }
    }
}
