using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03AplikacjaZawodnicy
{
    public partial class FrmZawodnicy : Form
    {



        FrmSzczegoly fs;
        ManagerZawodnikow mz;
        public FrmZawodnicy()
        {
            InitializeComponent();
        }

        public void Odswiez(Zawodnik[] zawodnicy)
        {
            lbDane.DisplayMember = "";
            lbDaneMiasta.DisplayMember = "";
            lbDane.DataSource = zawodnicy;
            lbDane.DisplayMember = "WidoczneDane";
            lbDaneMiasta.DataSource = zawodnicy;
            lbDaneMiasta.DisplayMember = "WidoczneDaneDwa";
            lblSredniaTemp.Text = Convert.ToString(mz.SredniaTemperaturaDanegKraju());
            lblSrTempAll.Text = Convert.ToString(mz.SredniaTemperaturaWszystkichRekordow());

            lblLiczba.Text = Convert.ToString(zawodnicy.Length);

        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //lbDane.Items.Clear();
                //foreach (var w in dane)
                //    lbDane.Items.Add(w);
                string namePaths = ofd.FileName;
                string[] dane = File.ReadAllLines(namePaths);
                mz = new ManagerZawodnikow(txtKraj.Text, ofd.FileName);

                try
                {
                    Zawodnik[] zawodnicy = mz.Wczytaj(dane);

                    Odswiez(zawodnicy);
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczone = (Zawodnik)lbDane.SelectedItem;
            fs = new FrmSzczegoly(mz, this, zaznaczone);
            fs.Show();
            //fs.TxtKraj.Text = zaznaczone.Kraj;
            //fs.TxtImie.Text = zaznaczone.Imie;
            //fs.TxtNazwisko.Text = zaznaczone.Nazwisko;
            //fs.DtpDataUr.Value = zaznaczone.DataUr;
            //fs.Waga.Value = zaznaczone.Waga;
            //fs.Wzrost.Value = zaznaczone.Wzrost;


        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            fs = new FrmSzczegoly(mz, this);
            fs.Show();
        }

        private void rbKolumna_Click(object sender, EventArgs e)
        {
            Sortowanie s;
            if (rbImie.Checked)
                s = Sortowanie.Imie;
            else if (rbNazwisko.Checked)
                s = Sortowanie.Nazwisko;
            else if (rbWzrost.Checked)
                s = Sortowanie.Wzrost;
            else
                throw new Exception("Błąd");

                mz.Sortuj(s);
            Odswiez(mz.WczytaniZawodnicy);
        }
    }
}
