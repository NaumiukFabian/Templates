using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04AutentykacjaAplikacjiDesktopowej
{
    public partial class frmLogowanie : Form
    {
        public frmLogowanie()
        {
            InitializeComponent();
        }

        private void brnZaloguj_Click(object sender, EventArgs e)
        {
            string uzytkownik = txtLogin.Text;
            string haslo = txtHaslo.Text;

            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            var all = db.aspnet_Users.Where(x => x.LoweredUserName == uzytkownik.ToLower()).FirstOrDefault();

            if(all == null)
            {
                MessageBox.Show("Niepoprawne logowanie");
                return;
            }

            string nazwaUzytkownikaZBazy = all.LoweredUserName;
            string hashHasla = all.aspnet_Membership.Password;

            string mojHash = EncodePassword(haslo, all.aspnet_Membership.PasswordSalt);

            if (mojHash == hashHasla)
            {
                Form1 fs = new Form1();
                fs.Show();
                this.Hide();
            }

        }

        private string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        private string EncodePassword(string pass, string salt)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(pass);
            byte[] src = Convert.FromBase64String(salt);
            byte[] dst = new byte[src.Length + bytes.Length];
            byte[] inArray = null;
            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);
            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
