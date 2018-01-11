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
    public partial class Tehnika : Form
    {
        public static string alertString = "Toode  on lisatud ostukorvi!";

        public static string path = @"..\..\..\Inventory.txt";

        public Tehnika()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void NklapidNupp_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 4;
            Ostja.Summa += 4;
            string tehnika1 = System.Environment.NewLine + " Nööp-kõrvaklapid, 4€";
            File.AppendAllText(path, tehnika1);
            alert.Text = alertString + " " + NklapidNupp.Text;
        }

        private void SklapidNupp_Click_1(object sender, EventArgs e)
        {
            string tehnika2 = System.Environment.NewLine + " Suured kõrvaklapid, 15€";
            File.AppendAllText(path, tehnika2);
            Ostja.Raha -= 15;
            Ostja.Summa += 15;
            alert.Text = alertString + " " + SklapidNupp.Text;
        }

        private void JBLboxNupp_Click_1(object sender, EventArgs e)
        {
            string tehnika3 = System.Environment.NewLine + " JBL väike kõlar, 30€";
            File.AppendAllText(path, tehnika3);
            Ostja.Raha -= 30;
            Ostja.Summa += 30;
            alert.Text = alertString + " " + JBLboxNupp.Text;
        }

        private void JBLexNupp_Click_1(object sender, EventArgs e)
        {
            string tehnika4 = System.Environment.NewLine + " JBL Extreme, 340€";
            File.AppendAllText(path, tehnika4);
            Ostja.Raha -= 340;
            Ostja.Summa += 340;
            alert.Text = alertString + " " + JBLexNupp.Text;
        }

        private void MyPhoneNupp_Click_1(object sender, EventArgs e)
        {
            string tehnika5 = System.Environment.NewLine + " MyPhone telefon, 50€";
            File.AppendAllText(path, tehnika5);
            Ostja.Raha -= 50;
            Ostja.Summa += 50;
            alert.Text = alertString + " " + MyPhoneNupp.Text;
        }

        private void MonitorNupp_Click_1(object sender, EventArgs e)
        {
            string tehnika6 = System.Environment.NewLine + " LG monitor, 120€";
            File.AppendAllText(path, tehnika6);
            Ostja.Raha -= 120;
            Ostja.Summa += 120;
            alert.Text = alertString + " " + MonitorNupp.Text;
        }

        private void HiirNupp_Click_1(object sender, EventArgs e)
        {
            string tehnika7 = System.Environment.NewLine + " Juhtmevaba hiir, 25€";
            File.AppendAllText(path, tehnika7);
            Ostja.Raha -= 25;
            Ostja.Summa += 25;
            alert.Text = alertString + " " + HiirNupp.Text;
        }

        private void KlaviNupp_Click_1(object sender, EventArgs e)
        {
            string tehnika8 = System.Environment.NewLine + " Klaviatuur taustavalgustusega, 75€";
            File.AppendAllText(path, tehnika8);
            Ostja.Raha -= 75;
            Ostja.Summa += 75;
            alert.Text = alertString + " " + KlaviNupp.Text;
        }

        private void TVnupp_Click_1(object sender, EventArgs e)
        {
            string tehnika9 = System.Environment.NewLine + " LG televiisor, 320€";
            File.AppendAllText(path, tehnika9);
            Ostja.Raha -= 320;
            Ostja.Summa += 320;
            alert.Text = alertString + " " + TVnupp.Text;
        }

        private void MaluNupp_Click_1(object sender, EventArgs e)
        {
            string tehnika10 = System.Environment.NewLine + " 16GB mälupulk, 15€";
            File.AppendAllText(path, tehnika10);
            Ostja.Raha -= 15;
            Ostja.Summa += 15;
            alert.Text = alertString + " " + MaluNupp.Text;
        }


        private void Tehnika_Load(object sender, EventArgs e)
        {

        }
        private void ToRiidedNupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Riided r = new Riided();
            r.ShowDialog();
            this.Close();

        }

        private void Algusesse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void KassasseNupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeeOnKassa k = new SeeOnKassa();
            k.ShowDialog();
            this.Close();
        }

        private void ToManguasjadNupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manguasjad m = new Manguasjad();
            m.ShowDialog();
            this.Close();
        }

        private void OstukorvNupp_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            Process.Start(@"..\..\..\Inventory.txt");
            p.Close();

        }
    }
}
