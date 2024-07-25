using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace proiectPAW
{
    public partial class Form7 : Form
    {
        Comanda comanda;
        public Form7(Comanda comanda)
        {
            InitializeComponent();
            this.comanda = comanda;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<Produs> produs = new List<Produs>();
            bool bifatShaormaMicaPui = checkBox1.Checked;
            if (bifatShaormaMicaPui)
                produs.Add(new Produs("Shaorma Mica Pui", 1,31.00M));
            bool bifatShaormaMarePui = checkBox2.Checked;
            if (bifatShaormaMarePui)
                produs.Add(new Produs("Shaorma Mare Pui", 1, 36.00M));
            bool bifatFarfuriePui = checkBox3.Checked;
            if (bifatFarfuriePui)
                produs.Add(new Produs("Farfurie Pui", 1, 41.00M));
            bool bifatDonerPui = checkBox4.Checked;
            if (bifatDonerPui)
                produs.Add(new Produs("Doner Pui", 1, 27.00M));
            bool bifatShaormaMicaVita = checkBox5.Checked;
            if (bifatShaormaMicaVita)
                produs.Add(new Produs("Shaorma Mica Vita", 1, 35.00M));
            bool bifatShaormaMareVita = checkBox6.Checked;
            if (bifatShaormaMareVita)
                produs.Add(new Produs("Shaorma Mare Vita", 1, 40.00M));
            bool bifatFarfurieVita = checkBox7.Checked;
            if (bifatFarfurieVita)
                produs.Add(new Produs("Farfurie Vita", 1, 44.00M));
            bool bifatShaormaMicaMixt = checkBox8.Checked;
            if (bifatShaormaMicaMixt)
                produs.Add(new Produs("Shaorma Mica Mixt", 1, 34.00M));
            bool bifatShaormaMareMixt = checkBox9.Checked;
            if (bifatShaormaMareMixt)
                produs.Add(new Produs("Shaorma Mare Mixt", 1, 39.00M));
            bool bifatFarfurieMixt = checkBox10.Checked;
            if (bifatFarfurieMixt)
                produs.Add(new Produs("Farfurie Mixt", 1, 29.00M));
            bool bifatDonerMixt = checkBox11.Checked;
            if (bifatDonerMixt)
                produs.Add(new Produs("Doner Mixt", 1, 43.00M));
            bool bifatHalloumi = checkBox12.Checked;
            if (bifatHalloumi)
                produs.Add(new Produs("Halloumi", 1, 27.00M));
            bool bifatRosii = checkBox13.Checked;
            if (bifatRosii)
                produs.Add(new Produs("Rosii", 1, 0.00M));
            bool bifatVarza = checkBox14.Checked;
            if (bifatVarza)
                produs.Add(new Produs("Varza", 1, 0.00M));
            bool bifatCastravetiMurati = checkBox15.Checked;
            if (bifatCastravetiMurati)
                produs.Add(new Produs("Castraveti Murati", 1, 0.00M));
            bool bifatSalata = checkBox16.Checked;
            if (bifatSalata)
                produs.Add(new Produs("Salata", 1, 0.00M));
            bool bifatCeapa = checkBox17.Checked;
            if (bifatCeapa)
                produs.Add(new Produs("Ceapa", 1, 0.00M));
            bool bifatCartofi = checkBox18.Checked;
            if (bifatCartofi)
                produs.Add(new Produs("Cartofi", 1, 0.00M));
            bool bifatSosDulce = checkBox19.Checked;
            if (bifatSosDulce)
                produs.Add(new Produs("SosDulce", 1, 0.00M));
            bool bifatSosPicant = checkBox20.Checked;
            if (bifatSosPicant)
                produs.Add(new Produs("Sos Picant", 1, 0.00M));
            bool bifatMaionezaUsturoi = checkBox21.Checked;
            if (bifatMaionezaUsturoi)
                produs.Add(new Produs("Maioneza Usturoi", 1, 0.00M));
            bool bifatMaionezaPicanta = checkBox22.Checked;
            if (bifatMaionezaPicanta)
                produs.Add(new Produs("Maioneza Picanta", 1, 0.00M));
            bool bifatApaPlata = checkBox23.Checked;
            if (bifatApaPlata)
                produs.Add(new Produs("Apa Plata", 1, 8.00M));
            bool bifatApaMinerala = checkBox24.Checked;
            if(bifatApaMinerala)
                produs.Add(new Produs("Apa Minerala",1,10.00M));
            bool bifatPepsi = checkBox25.Checked;
            if (bifatPepsi)
                produs.Add(new Produs("Pepsi", 1, 12.00M));
            bool bifatFanta = checkBox26.Checked;
            if(bifatFanta)
                produs.Add(new Produs("Fanta",1,12.00M));
            bool bifatSprite = checkBox27.Checked;
            if (bifatSprite)
                produs.Add(new Produs("Sprite",1,12.00M));
            bool bifatLimonada = checkBox28.Checked;
            if (bifatLimonada)
                produs.Add(new Produs("Limonada",1,14.00M));
            bool bifatAyran = checkBox29.Checked;
            if (bifatAyran)
                produs.Add(new Produs("Ayran",1,11.00M));
            bool bifatBaklava = checkBox30.Checked;
            if (bifatBaklava)
                produs.Add(new Produs("Baklava", 1, 10.00M));
            bool bifatTavukGogsu = checkBox31.Checked;
            if (bifatTavukGogsu)
                produs.Add(new Produs("Tavuk Gogsu", 1, 12.00M));
            bool bifatFirinSutlac = checkBox32.Checked;
            if(bifatFirinSutlac)
                produs.Add(new Produs("Firin Sutlac",1,15.00M));
            comanda.Produs = produs;
            DialogResult = DialogResult.OK;


        
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
