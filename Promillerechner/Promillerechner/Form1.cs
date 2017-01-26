using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promillerechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btn_berechnen_Click(object sender, EventArgs e)
        {
            string geschlecht;
            if (rbtn_maennlich.Checked == true)
                geschlecht = "m";
            else
                geschlecht = "w";
            Berechnen(nud_gewicht.Value, nud_alkoholanteil.Value, tbx_menge.Text, geschlecht);
        }
    }
}
