using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PolaczenieZBaza
{
    internal class PolaczenieZBaza
    {

        private string connString;
        public PolaczenieZBaza(string connString)
        {
            this.connString = connString;
        }

        public object[][] WykonajZapytanie(string sql)
        {
            SqlConnection connection; // do nawiazana polaczenia z baza
            SqlCommand command; // przechowuje polecenia sql - zapytania
            SqlDataReader sqlDataReader; // czytanie wynikow z tabelki

            connection = new SqlConnection(connString);

            command = new SqlCommand(sql, connection);

            connection.Open();

            sqlDataReader = command.ExecuteReader(); // wysyła polecenie do bazy danych

            int liczbaKolumn = sqlDataReader.FieldCount;

            //tworzymy liste bo nie znamy ostatecznej liczby wierszy. To jest lista komorek
            List<object[]> listaWierszy = new List<object[]>();

            while (sqlDataReader.Read())
            {
                object[] komorki = new object[liczbaKolumn];
                for(int i = 0; i < liczbaKolumn; i++)
                    komorki[i] = sqlDataReader.GetValue(i);
                listaWierszy.Add(komorki);
            }

            connection.Close();
            return listaWierszy.ToArray();
        }
    }
}
