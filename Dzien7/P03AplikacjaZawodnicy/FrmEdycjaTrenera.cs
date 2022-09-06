using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03AplikacjaZawodnicy
{
    public partial class FrmEdycjaTrenera : Form
    {
        private FrmZawodnicy frmZawodnicy;
        private TrenerVM trener;
        public FrmEdycjaTrenera(TrenerVM trener, FrmZawodnicy frmZawodnicy)
        {
            InitializeComponent();
            ZczytajTrenera(trener);
            this.frmZawodnicy = frmZawodnicy;
            btnUsun.Visible = true;

        }

        public FrmEdycjaTrenera()
        {
            InitializeComponent();
            btnZapisz.Visible = false;
            btnDodaj.Visible = true;
            
        }

        public void ZczytajTrenera(TrenerVM trener)
        {
            this.trener = trener;
            txtImieTrenera.Text = trener.Imie;
            txtNazwiskoTrenera.Text = trener.Nazwisko;
            dtpDataUr.Value = trener.DataUrd == null ? DateTime.Now : (DateTime)trener.DataUrd;
        }

        public void UstawDane()
        {
            trener.Imie = txtImieTrenera.Text;
            trener.Nazwisko = txtNazwiskoTrenera.Text;
            trener.DataUrd = dtpDataUr.Value;
        }

        public void StworzTrenera()
        {
            TrenerVM nowyTrener = new TrenerVM();
            nowyTrener.Imie = txtImieTrenera.Text;
            nowyTrener.Nazwisko = txtNazwiskoTrenera.Text;
            nowyTrener.DataUrd = dtpDataUr.Value;
            TrenerRepository tr = new TrenerRepository();
            tr.DodajTrenera(nowyTrener);
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            UstawDane();
            TrenerRepository tr = new TrenerRepository();
            tr.EdytujTrenera(trener);
            frmZawodnicy.OdswiezTrener();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            StworzTrenera();
            MessageBox.Show("Dodano trenera", "Gotowe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            TrenerRepository tr = new TrenerRepository();
            tr.UsunTrenera(trener);
            frmZawodnicy.OdswiezTrener();
        }
    }
}
