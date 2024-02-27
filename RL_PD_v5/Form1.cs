using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RL_PD_v5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int daudzums = Convert.ToInt32(textBox2.Text);
            int banans = 105;
            int sviestmaize = 75;
            int abols = 55;
            int kalorijasUzVienibu = 0;

            if (Ediens.Text == "Banans")
            {
                kalorijasUzVienibu = banans;
            }

            if (Ediens.Text == "Sviestmaize")
            {
                kalorijasUzVienibu = sviestmaize;
            }

            if (Ediens.Text == "Abols")
            {
                kalorijasUzVienibu = abols;
            }


            double kopejasKalorijas = kalorijasUzVienibu * daudzums;
            textBox3.Text = kopejasKalorijas.ToString();

        }
    }
}
