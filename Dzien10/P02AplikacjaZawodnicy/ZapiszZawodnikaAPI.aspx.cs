using P05BibliotekaZawodnikVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P06Powtorzenie
{
    public partial class ZapiszZawodnikaAPI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Request["id"]);
                string imie = Request["imie"];
                string nazwisko = Request["nazwisko"];
                string kraj = Request["kraj"];
                string miasto = Request["miasto"];
                int waga = Convert.ToInt32(Request["waga"]);
                int wzrost = Convert.ToInt32(Request["wzrost"]);
                //int[] dates = Request["dataUr"].Split('-').Select(x => Convert.ToInt32(x)).ToArray();
                //DateTime dataur = Convert.ToDateTime(Request["dataUr"]);
                //DateTime dataur = new DateTime(dates[2], dates[1], dates[0]);
                string dates = Request["dataUr"];
                DateTime dataur = DateTime.ParseExact(dates,"dd-MM-yyy", System.Globalization.CultureInfo.InvariantCulture);

                ZawodnicyRepository zr = new ZawodnicyRepository();
                ZawodnikVM zw = new ZawodnikVM()
                {
                    Imie = imie,
                    Nazwisko = nazwisko,
                    Kraj = kraj,
                    Miasto = miasto,
                    Waga = waga,
                    Wzrost = wzrost,
                    DataUr = dataur,
                    Id_zawodnika = id
                };

                zr.EdytujZawodnika(zw);
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}