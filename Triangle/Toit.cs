using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Triangle
{
    public partial class Toit : Form
    {
        public static string alertString = "Toode  on lisatud ostukorvi!";

        public static string path = @"..\..\..\Inventory.txt";
        public Toit()
        {
            InitializeComponent();
        }

        private void Toid_Load(object sender, EventArgs e)
        {

        }

        private void Avokaado_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 5;
            string toit3 = System.Environment.NewLine + "Avokaado, 1kg 5€";
            File.AppendAllText(path, toit3);
            alert.Text = alertString + " " + Avokaado.Text;
        }

        private void alco_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 5;
            string toit4 = System.Environment.NewLine + " J.P. Chenet Rose Medium Sweet 75cl Tavahind 6€ SOODUS 5€";
            File.AppendAllText(path, toit4);
            alert.Text = alertString + " " + alco.Text;
        }

        private void koer_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 2;
            string toit5 = System.Environment.NewLine + " Kirju koer batoonike, KALEV, 200g 2€";
            File.AppendAllText(path, toit5);
            alert.Text = alertString + " " + koer.Text;
        }

        private void mahl_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 2;
            string toit6 = System.Environment.NewLine + " Õunamahl, PÕLTSAMAA, 1L 2€";
            File.AppendAllText(path, toit6);
            alert.Text = alertString + " " + mahl.Text;
        }

        private void sai_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 1;
            string toit7 = System.Environment.NewLine + "Suur Kodusai, FAZER, 500g 1€ ";
            File.AppendAllText(path, toit7);
            alert.Text = alertString + " " + sai.Text;
        }

        private void piim_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 2;
            string toit8 = System.Environment.NewLine + "Täispiim pure, FARMI, 1L 2€";
            File.AppendAllText(path, toit8);
            alert.Text = alertString + " " + piim.Text;
        }

        private void artur_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 2;
            string toit9 = System.Environment.NewLine + " Kass Arturi iirisepallid, VÄIKE VÄÄNIK, 150g Tavahind 2€ SOODUS 2€";
            File.AppendAllText(path, toit9);
            alert.Text = alertString + " " + artur.Text;
        }

        private void just_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 5;
            string toit10 = System.Environment.NewLine + "Eesti juust 25,2% viilutatud, TRADITSIOONILINE EESTI JUUST, 500g 5€ ";
            File.AppendAllText(path, toit10);
            alert.Text = alertString + " " + just.Text;
        }

        private void sushi_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 2;
            string toit12 = System.Environment.NewLine + "Coca-Cola, COCA-COLA, 2L 2€ ";
            File.AppendAllText(path, toit12);
            alert.Text = alertString + " " + coca.Text;
        }

        private void coca_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 2;
            string toit12 = System.Environment.NewLine + "Coca-Cola, COCA-COLA, 2L 2€ ";
            File.AppendAllText(path, toit12);
            alert.Text = alertString + " " + coca.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 3;
            string toit1 = System.Environment.NewLine + "Kartulikrõpsud Koore-Sibula, PRINGLES, 165g 3€";
            File.AppendAllText(path, toit1);
            alert.Text = alertString + " " + button11.Text;
        }

        private void activia_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 1;
            string toit13 = System.Environment.NewLine + "Joogijogurt maasika-kiivi, ACTIVIA, 300g 1€ ";
            File.AppendAllText(path, toit13);
            alert.Text = alertString + " " + activia.Text;
        }

        private void kako_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 3;
            string toit14 = System.Environment.NewLine + "Lahustuv kakao, NESQUIK, 400g 3€ ";
            File.AppendAllText(path, toit14);
            alert.Text = alertString + " " + kako.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 8;
            string toit2 = System.Environment.NewLine + "Tualettpaber Delux Pure White, 3, ZEWA, 16rl 8€";
            File.AppendAllText(path, toit2);
            alert.Text = alertString + " " + button14.Text;
        }

        private void Algus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void Toys_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manguasjad t = new Manguasjad();
            t.ShowDialog();
            this.Close();
        }

        private void Clothing_Click(object sender, EventArgs e)
        {
            this.Hide();
            Riided r = new Riided();
            r.ShowDialog();
            this.Close();
        }

        private void ostukorv_Click(object sender, EventArgs e)
        {

            Process p = new Process();
            Process.Start(@"..\..\Inventory.txt");
            p.Close();

        }

        private void kassa_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeeOnKassa k = new SeeOnKassa();
            k.ShowDialog();
            this.Close();
        }
    }
}
