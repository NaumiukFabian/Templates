using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PolaczenieZBaza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connString = "Data Source=.\\SQLEXPRESS;Initial Catalog=A_Zawodnicy;Integrated Security=True";
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            object[][] wyink = pzb.WykonajZapytanie("select imie,nazwisko,kraj from zawodnicy");
            
            for(int i = 0; i < wyink.Length; i++)
                Console.WriteLine(String.Join(" ", wyink[i]));

            Console.ReadKey();
        }
    }
}
