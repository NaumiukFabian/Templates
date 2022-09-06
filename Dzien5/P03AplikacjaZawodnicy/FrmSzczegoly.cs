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
    public partial class FrmSzczegoly : Form
    {
        private enum TrybOkienka
        {
            Edycja,
            Nowy
        }

        private Zawodnik zawodnik;
        private ManagerZawodnikow mz;
        private FrmZawodnicy frmZawodnicy;
        private TrybOkienka trybokienka => zawodnik == null ? TrybOkienka.Nowy : TrybOkienka.Edycja;
        //public TextBox TxtImie => this.txtImie;
        //public TextBox TxtNazwisko => this.txtNazwisko;
        //public TextBox TxtKraj => this.txtKraj;
        //public DateTimePicker DtpDataUr => this.dtpDataUrodzin;
        //public NumericUpDown Waga => this.numWaga;
        //public NumericUpDown Wzrost => this.numWzrost;

        public FrmSzczegoly(ManagerZawodnikow mz, FrmZawodnicy frmZawodnicy)
        {
            InitializeComponent();
            this.mz = mz;
            this.frmZawodnicy = frmZawodnicy;
        }

        public FrmSzczegoly(ManagerZawodnikow mz, FrmZawodnicy frmZawodnicy, Zawodnik zawodnik) : this(mz, frmZawodnicy)
        {

            this.zawodnik = zawodnik;
            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;
            dtpDataUrodzin.Value = zawodnik.DataUr;
            numWaga.Value = zawodnik.Waga;
            numWzrost.Value = zawodnik.Wzrost;
            btnUsun.Visible = true;

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            

            if (trybokienka == TrybOkienka.Edycja)
            {
                uzupelnijPola();
                mz.Edytuj(zawodnik);
            }
            else if (trybokienka == TrybOkienka.Nowy)
            {
                zawodnik = new Zawodnik();
                uzupelnijPola();
                mz.StowrzNowego(zawodnik);
            }
            else
                throw new Exception("Nieznany tryb okienka");

            mz.Zapisz();

            frmZawodnicy.Odswiez(mz.WczytaniZawodnicy);
        }

        private void uzupelnijPola()
        {
            zawodnik.Imie = txtImie.Text;
            zawodnik.Nazwisko = txtNazwisko.Text;
            zawodnik.Kraj = txtKraj.Text;
            zawodnik.DataUr = dtpDataUrodzin.Value;
            zawodnik.Waga = Convert.ToInt32(numWaga.Value);
            zawodnik.Wzrost = Convert.ToInt32(numWzrost.Value);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult dr =
            MessageBox.Show("Czy na pewno chcesz usunąć zadownika?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                mz.Usun(zawodnik);
                mz.Zapisz();
                frmZawodnicy.Odswiez(mz.WczytaniZawodnicy);
                Close();
            }

            
        }
    }
}
