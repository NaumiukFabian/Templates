
using P05BibliotekaZawodnikVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P06Powtorzenie
{
    
    public partial class ZawodnicyAPI : System.Web.UI.Page
    {
        public ZawodnikVM[] Zawodnicyy;
        protected void Page_Load(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnicyy = zr.WczytajZawodnikow("", "");
        }
    }
}