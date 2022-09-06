using P04BibliotekaPDF;
using P05BibliotekaZawodnikVM;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace P03AplikacjaZawodnicy
{
    public partial class FrmZawodnicy : Form
    {



        FrmSzczegoly fs;
        FrmEdycjaTrenera fe;
        public FrmZawodnicy()
        {
            InitializeComponent();
        }

        public void Odswiez()
        {
            string sortowanie = null;
            if (rbImie.Checked)
                sortowanie = (string)rbImie.Tag;
            else if(rbNazwisko.Checked)
                sortowanie= (string)rbNazwisko.Tag;
            else if(rbWzrost.Checked)
                sortowanie=(string)rbWzrost.Tag;

            ZawodnicyRepository zr = new ZawodnicyRepository();
            ZawodnikVM[] zawodnicy = zr.WczytajZawodnikow(txtFiltr.Text, sortowanie);
            lbDane.DataSource = zawodnicy;
            lbDane.DisplayMember = "WidoczneDane";
            lblLiczba.Text = zawodnicy.Length.ToString();

        }

        public void OdswiezTrener()
        {
            TrenerRepository tr = new TrenerRepository();
            TrenerVM[] trenerzy = tr.WczytajTrenera();
            lbDaneMiasta.DataSource = trenerzy;
            lbDaneMiasta.DisplayMember = "WidoczneDane";
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {  
            Odswiez();
            WygenerujWykres();
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            ZawodnikVM zaznaczony = (ZawodnikVM)lbDane.SelectedItem;
            fs = new FrmSzczegoly(this, zaznaczony);
            fs.Show();
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            fs = new FrmSzczegoly(this);
            fs.Show();
        }

        private void btnWczytajTrenerow_Click(object sender, EventArgs e)
        {
            OdswiezTrener();
        }

        private void btnEdycjaTrenera_Click(object sender, EventArgs e)
        {
            TrenerVM zaznaczonyTrener = (TrenerVM)lbDaneMiasta.SelectedItem;
            fe = new FrmEdycjaTrenera(zaznaczonyTrener, this);
            fe.Show();

        }

        private void btnDodajTrenera_Click(object sender, EventArgs e)
        {
            fe = new FrmEdycjaTrenera();
            fe.Show();
        }

        private void WygenerujWykres()
        {
            chartWykres.Series.Clear();

            Series seria = new Series("Wzrost");
            seria.ChartType = SeriesChartType.Column;

            var zawodnicy = (ZawodnikVM[])lbDane.DataSource;
            var grupy = zawodnicy.GroupBy(x => x.Kraj).Select(x => new
            {
                osX = x.Key,
                osY = x.Average(y => y.Wzrost)
            });

            string[] wartosciX = grupy.Select(x => x.osX).ToArray();
            double[] wartosciY = grupy.Select(x => x.osY).ToArray();
            seria.Points.DataBindXY(wartosciX, wartosciY);

            chartWykres.Series.Add(seria);
        }

        private void btnPobierz_Click(object sender, EventArgs e)
        {
            PdfManager pdf = new PdfManager();
            var zawodnicy = (ZawodnikVM[])lbDane.DataSource;
            string nazwaPliku = pdf.StworzPDF(zawodnicy);

            string sciezka = AppDomain.CurrentDomain.BaseDirectory;
            wbPrzegladarka.Navigate(sciezka + nazwaPliku);
        }
    }
}
