using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05AplikacjaZawodnicy
{
    internal class TrenerRepository
    {
        private string connString = "Data Source=.\\SQLEXPRESS;Initial Catalog=A_Zawodnicy;Integrated Security=True";

        public Trener[] WczytajTrenera()
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            string sqlQuerry = "select * from trenerzy";
            object[][] resultOfQuerry =  pzb.WykonajZapytanie(sqlQuerry);
            Trener[] trener = new Trener[resultOfQuerry.Length];

            for(int i = 0; i < resultOfQuerry.Length; i++)
            {
                Trener iTrener = new Trener();

                iTrener.Id_trenra = (int)resultOfQuerry[i][0];
                iTrener.Imie = (string)resultOfQuerry[i][1];
                iTrener.Nazwisko = (string)resultOfQuerry[i][2];

                if (resultOfQuerry[i][3] != DBNull.Value)
                    iTrener.DataUrd = (DateTime)resultOfQuerry[i][3];
                else
                    iTrener.DataUrd = DateTime.Today;

                trener[i] = iTrener;      
            }

            return trener;
        }

        public void EdytujTrenera(Trener z)
        {
            string sqlQuerry = "update trenerzy set imie_t='{0}', nazwisko_t='{1}', data_ur_t='{2}' where id_trenera={3}";
            sqlQuerry = String.Format(sqlQuerry, z.Imie, z.Nazwisko, z.DataUrd.ToString("yyyy-MM-dd"), z.Id_trenra);
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            pzb.WykonajZapytanie(sqlQuerry);
        }

        public void DodajTrenera(Trener z)
        {
            string sqlQuerry = "insert into trenerzy (imie_t, nazwisko_t, data_ur_t) values ('{0}', '{1}', {2})";
            sqlQuerry = String.Format(sqlQuerry, z.Imie, z.Nazwisko, z.DataUrd.ToString("yyyy-MM-dd"));
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            pzb.WykonajZapytanie(sqlQuerry);
        }

        public void UsunTrenera(Trener z)
        {
            string sqlQuerry = $"delete from trenerzy where id_trenera = {z.Id_trenra}";
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            pzb.WykonajZapytanie(sqlQuerry);
        }
    }
}
