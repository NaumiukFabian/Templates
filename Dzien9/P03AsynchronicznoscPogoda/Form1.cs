using P02AplikacjaPogodaUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03AsynchronicznoscPogoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //    private async void button1_Click(object sender, EventArgs e)
        //    {
        //        MenagerPogody mp = new MenagerPogody(Jednostka.Celcjusz);

        //        for(int i = 0; i < listBox1.Items.Count; i++)
        //        {
        //            string miasto = listBox1.Items[i].ToString();
        //            double temp = mp.PodajTemperature(miasto);

        //            listBox2.Items.Add($"temp w miescie {miasto} wynosi {temp}");
        //        }
        //    }
        //}

        private async void button1_Click(object sender, EventArgs e)
        {
            MenagerPogody mp = new MenagerPogody(Jednostka.Celcjusz);

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string miasto = listBox1.Items[i].ToString();
                var t = Task.Run<double>(() =>
                {
                    double d = mp.PodajTemperature(miasto);
                    return d;
                });

                t.GetAwaiter().OnCompleted(() =>
                {
                    listBox2.Items.Add($"temp w miescie {miasto} wynosi {t.Result}");
                });
            }
        }
    }
}
