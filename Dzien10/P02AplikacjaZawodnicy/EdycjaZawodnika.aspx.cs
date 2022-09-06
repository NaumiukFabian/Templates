using P05BibliotekaZawodnikVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P06Powtorzenie
{
    public partial class EdycjaZawodnika : System.Web.UI.Page
    {
        public ZawodnikVM Zawodnik;
        protected void Page_Load(object sender, EventArgs e)
        {
            string idZawodnika = Request["id"];
            int id;
            if (!int.TryParse(idZawodnika, out id))
                    Response.Redirect("Erorr.aspx");
            else if (id > 0)
            {
                ZawodnicyRepository zr = new ZawodnicyRepository();
                Zawodnik = zr.WczytajZawodnika(id);
                txtImie.Text = Zawodnik.Imie;
                txtNazwisko.Text = Zawodnik.Nazwisko;
                txtMiasto.Text = Zawodnik.Miasto;
                txtKraj.Text = Zawodnik.Kraj;
                txtDataUr.Text = Zawodnik.DataUr?.ToString("dd-MM-yyyy");
                txtWaga.Text = Zawodnik.Waga.ToString();
                txtWzrost.Text = Zawodnik.Wzrost.ToString();
                //btnUsun.Visible = true;
            }
        }
    }
}