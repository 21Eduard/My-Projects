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

    public partial class Form6 : Form
    {
        Client cl = new Client();
        Comanda c = null;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            c = new Comanda();
            Form7 form7 = new Form7(c);
            form7.ShowDialog();
            this.Hide();
            Factura f = new Factura(121, cl, c.Produs);
            f.AfisareDetaliiFactura();
            Form8 form = new Form8(f);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            cl.Nume= textBox1.Text;
            cl.Prenume= textBox2.Text;
            cl.AdresaClient= textBox3.Text;
            cl.NumarTelefon= textBox4.Text;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
