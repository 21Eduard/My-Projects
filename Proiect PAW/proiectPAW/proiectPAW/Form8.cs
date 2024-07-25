using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPAW
{
    public partial class Form8 : Form
    {
        Factura f;

        public Form8(Factura f)
        {
            InitializeComponent();

            this.f = f;
            label1.Text = f.Client.ToString();
            label2.Text = "ID Factura:"+f.IdFactura.ToString()+"\n";
            string str = "";
            foreach (Produs produs in f.Produs)
            {
                str += produs.ToString();
            }
            label3.Text = str;
            decimal total = 0.00M;
            if (f.Produs.Count > 0)
            {

                foreach (var p in f.Produs)
                {
                    total += p.Pret;
                }
            }

            //label4.Text = "Pret Total: " + total.ToString("N2") + " Lei";
            label4.Text = "Pret Total: " + total.ToString("C", new System.Globalization.CultureInfo("ro-RO"));


        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
