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
    public partial class NullableDateTimePicer : UserControl
    {

        public DateTime? Value
        {
            get
            {
                if(dtpData.Visible)
                    return dtpData.Value;
                return null;
            }

            set
            {
                if(value == null)
                {
                    txtData.Visible = true;
                    dtpData.Visible = false;
                }
                else
                {
                    txtData.Visible = false;
                    dtpData.Visible = true;
                    dtpData.Value = (DateTime)value;
                }
            }
        }
        public NullableDateTimePicer()
        {
            InitializeComponent();
        }

        private void txtData_Click(object sender, EventArgs e)
        {
            txtData.Visible = false;
            dtpData.Visible = true;
        }

        private void dtpData_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                txtData.Visible = true;
                dtpData.Visible = false;
            }
        }
    }
}
