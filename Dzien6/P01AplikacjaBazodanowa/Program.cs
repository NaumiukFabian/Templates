using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaBazodanowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection; // do nawiazana polaczenia z baza
            SqlCommand command; // przechowuje polecenia sql - zapytania
            SqlDataReader sqlDataReader; // czytanie wynikow z tabelki

            string connString = "Data Source=.\\SQLEXPRESS;Initial Catalog=A_Zawodnicy;Integrated Security=True";
            connection = new SqlConnection(connString);

            command = new SqlCommand("select * from zawodnicy", connection);

            connection.Open();

            sqlDataReader = command.ExecuteReader(); // wysyła polecenie do bazy danych

            //sqlDataReader.Read();

            //string wynik =  (string)sqlDataReader.GetValue(2);

            //Console.WriteLine(wynik);

            //sqlDataReader.Read();

            //wynik = (string)sqlDataReader.GetValue(2);

            //Console.WriteLine(wynik);


            while (sqlDataReader.Read())
            {
                string wynik = (string)sqlDataReader.GetValue(2) + " " + (string)sqlDataReader.GetValue(3);

                Console.WriteLine(wynik);
            }

            connection.Close();

            Console.ReadKey();



        }
    }
}
