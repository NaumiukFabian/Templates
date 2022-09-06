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

namespace P05AplikacjaZawodnicy
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
            Zawodnik[] zawodnicy = zr.WczytajZawodnikow(txtFiltr.Text, sortowanie);
            lbDane.DataSource = zawodnicy;
            lbDane.DisplayMember = "WidoczneDane";
            lblLiczba.Text = zawodnicy.Length.ToString();

        }

        public void OdswiezTrener()
        {
            TrenerRepository tr = new TrenerRepository();
            Trener[] trenerzy = tr.WczytajTrenera();
            lbDaneMiasta.DataSource = trenerzy;
            lbDaneMiasta.DisplayMember = "WidoczneDane";
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {  
            Odswiez();
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;
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
            Trener zaznaczonyTrener = (Trener)lbDaneMiasta.SelectedItem;
            fe = new FrmEdycjaTrenera(zaznaczonyTrener, this);
            fe.Show();

        }

        private void btnDodajTrenera_Click(object sender, EventArgs e)
        {
            fe = new FrmEdycjaTrenera();
            fe.Show();
        }
    }
}
