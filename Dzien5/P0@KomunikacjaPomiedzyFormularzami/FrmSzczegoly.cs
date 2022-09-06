using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P0_KomunikacjaPomiedzyFormularzami
{
    public partial class FrmSzczegoly : Form
    {
        private FrmStartowy frmStartowy; // rodzic

        public TextBox TxtDane
        {
            get
            {
                return txtDane;
            }
        }

        public FrmSzczegoly(FrmStartowy frmStartowy)
        {
            this.frmStartowy = frmStartowy;
            InitializeComponent();
        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            frmStartowy.TxtDane.Text = txtDane.Text;
        }
    }
}
