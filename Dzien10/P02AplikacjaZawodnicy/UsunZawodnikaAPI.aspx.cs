using P05BibliotekaZawodnikVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P06Powtorzenie
{
    public partial class UsunZawodnikaAPI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Request["id"]);

                ZawodnicyRepository zr = new ZawodnicyRepository();
                zr.UsunZawodnika(id);
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}