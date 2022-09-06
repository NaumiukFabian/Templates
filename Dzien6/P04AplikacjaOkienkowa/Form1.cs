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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(txtConnString.Text);
            object[][] wynik = pzb.WykonajZapytanie(txtPolecenieSql.Text);
            dgvDane.Rows.Clear();
            dgvDane.ColumnCount = wynik[0].Length;

            foreach (var wiersz in wynik)
                dgvDane.Rows.Add(wiersz);
        }
    }
}
