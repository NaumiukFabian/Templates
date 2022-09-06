using P02AplikacjaZawodnicy;
using P05BibliotekaZawodnikVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01AplikacjaWebowa
{
    public partial class ZawodnicyForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            //var zawodnicy = db.Zawodnik.ToArray();

            //var zawodnicyVM = zawodnicy.Select(x => new ZawodnikVM
            //{
            //    Imie = x.imie,
            //    Nazwisko = x.nazwisko,
            //    DataUr = x.data_ur,
            //    Miasto = x.miasto,
            //    Kraj = x.kraj,
            //    Waga = x.waga ?? 0,
            //    Wzrost = x.wzrost ?? 0

            //});

            
        }

        protected void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void Odswiez()
        {
            string filtr = txtFiltr.Text;
            string sortowanie = "";

            foreach (var c in pnSortowanie.Controls)
            {
                if (c is RadioButton)
                    if (((RadioButton)c).Checked)
                        sortowanie = ((RadioButton)c).Text;
            }

            ZawodnicyRepository zr = new ZawodnicyRepository();
            var zawodnicyVM = zr.WczytajZawodnikow(filtr, sortowanie);

            lbDane.DataSource = zawodnicyVM;
            lbDane.DataTextField = "WidoczneDane";
            lbDane.DataValueField = "Id_zawodnika";
            lbDane.DataBind();
        }

        protected void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            int zaznaczone = Convert.ToInt32(lbDane.SelectedValue);
            ZawodnicyRepository zr = new ZawodnicyRepository();
            var z = zr.WczytajZawodnika(zaznaczone);
            txtImie.Text = z.Imie;
            txtNazwisko.Text = z.Nazwisko;
            txtKraj.Text = z.Kraj;
            txtMiasto.Text = z.Miasto;
            txtDataUr.Text = z.DataUr.ToString();
            txtWaga.Text = z.Waga.ToString();
            txtWzrost.Text = z.Wzrost.ToString();
        }

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            int zaznaczone = Convert.ToInt32(lbDane.SelectedValue);
            ZawodnicyRepository zr = new ZawodnicyRepository();
            ZawodnikVM z = ZczytajZawodnika();
            z.Id_zawodnika = zaznaczone;
            zr.EdytujZawodnika(z);

            Odswiez();
        }

        private ZawodnikVM ZczytajZawodnika()
        {
            ZawodnikVM z = new ZawodnikVM();
            
            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj = txtKraj.Text;
            z.Miasto = txtMiasto.Text;
            if(!string.IsNullOrEmpty(txtDataUr.Text))
                z.DataUr = Convert.ToDateTime(txtDataUr.Text);
            if (!string.IsNullOrEmpty(txtWaga.Text))
                z.Waga = Convert.ToInt32(txtWaga.Text);
            if (!string.IsNullOrEmpty(txtWzrost.Text))
                z.Wzrost = Convert.ToInt32(txtWzrost.Text);
            return z;
        }


        protected void btnUsun_Click(object sender, EventArgs e)
        {
            int zaznaczone = Convert.ToInt32(lbDane.SelectedValue);
            ZawodnicyRepository zr = new ZawodnicyRepository();
            ZawodnikVM z = new ZawodnikVM()
            {
                Id_zawodnika = zaznaczone
            };

            zr.UsunZawodnika(z);
            Odswiez();
        }

        protected void btnNowy_Click(object sender, EventArgs e)
        {
            ZawodnikVM z = ZczytajZawodnika();
            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.DodajZawodnika(z);
            Odswiez();
        }
    }
}