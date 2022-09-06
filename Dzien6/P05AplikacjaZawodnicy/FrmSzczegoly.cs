using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05AplikacjaZawodnicy
{
    public partial class FrmSzczegoly : Form
    {

        private Zawodnik zawodnik;
        private FrmZawodnicy frmZawodnicy;
        
        private enum TrybOkienka
        {
            Edycja,
            Nowy
        }

        private TrybOkienka trybOkienka => zawodnik == null ? TrybOkienka.Nowy : TrybOkienka.Edycja;


        public FrmSzczegoly( FrmZawodnicy frmZawodnicy)
        {
            InitializeComponent();
            this.frmZawodnicy = frmZawodnicy;
        }

        public FrmSzczegoly( FrmZawodnicy frmZawodnicy, Zawodnik zawodnik) : this(frmZawodnicy)
        {
            txtImie.Text = zawodnik.Imie;
            txtKraj.Text = zawodnik.Kraj;
            txtNazwisko.Text = zawodnik.Nazwisko;
            ndtpDataUr.Value = zawodnik.DataUr;
            numWaga.Value = zawodnik.Waga;
            numWzrost.Value = zawodnik.Wzrost;
            this.zawodnik = zawodnik;
            this.frmZawodnicy = frmZawodnicy;
            txtMiasto.Text = zawodnik.Miasto;
            WczytajTemperatur();
            btnUsun.Visible = true;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            


            ZawodnicyRepository zawodnicyRepository = new ZawodnicyRepository();

            if (trybOkienka == TrybOkienka.Edycja)
            {
                zczytajDaneZawodnika();
                zawodnicyRepository.EdytujZawodnika(zawodnik);
            }
            else if (trybOkienka == TrybOkienka.Nowy)
            {
                zawodnik = new Zawodnik();
                zczytajDaneZawodnika();
                zawodnicyRepository.DodajZawodnika(zawodnik);
            }
            else
                throw new Exception("Nieznany Tryb");


            frmZawodnicy.Odswiez();
            Close();
        }

        private void zczytajDaneZawodnika()
        {
            zawodnik.Imie = txtImie.Text;
            zawodnik.Nazwisko = txtNazwisko.Text;
            zawodnik.Kraj = txtKraj.Text;
            zawodnik.DataUr = ndtpDataUr.Value;
            zawodnik.Waga = Convert.ToInt32(numWaga.Value);
            zawodnik.Wzrost = Convert.ToInt32(numWzrost.Value);
            zawodnik.Miasto = txtMiasto.Text;
        }

        private void uzupelnijPola()
        {

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            
            ZawodnicyRepository zawodnicyRepository = new ZawodnicyRepository();
            zawodnicyRepository.UsunZawodnika(zawodnik);
            frmZawodnicy.Odswiez();
            Close();
        }

        private void WczytajTemperatur()
        {
            if (!string.IsNullOrEmpty(txtMiasto.Text))
            {
                MenagerPogody mp = new MenagerPogody(Jednostka.Celcjusz);
                double temp = mp.PodajTemperature(txtMiasto.Text);
                lblTemperatura.Text = temp.ToString();

                TemperaturyRepository tr = new TemperaturyRepository();
                Temperatura temperatura = new Temperatura();

                temperatura.Data = DateTime.Now;
                temperatura.Wartosc = Convert.ToInt32(temp);
                temperatura.Miasto = txtMiasto.Text;

                tr.DodajTemperature(temperatura);
            }
        }

    }
}
