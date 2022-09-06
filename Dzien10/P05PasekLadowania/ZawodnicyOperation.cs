using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06Powtorzenie
{
    internal class ZawodnicyOperation
    {
        ListBox lbDane;
        ProgressBar pbPasekPosteu;

        public ZawodnicyOperation(ListBox lbDane, ProgressBar pbPasekPosteu)
        {
            this.lbDane = lbDane;
            this.pbPasekPosteu = pbPasekPosteu;
        }

        public void WczytajWieluZawodnikow()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            int[] identyfikatory = zr.WczytajZawodnikow("", "").Select(x => x.Id_zawodnika).ToArray();

            pbPasekPosteu.Maximum = identyfikatory.Length;
            pbPasekPosteu.Value = 0;
            lbDane.Items.Clear();
            foreach(var id in identyfikatory)
            {
                var zawodnik = zr.WczytajZawodnika(id);
                pbPasekPosteu.Value++;
                lbDane.Items.Add("wczytano: " + zawodnik.Imie + " " + zawodnik.Nazwisko);
            }
          
        }
    }
}
