using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace Triangle
{
    public partial class Riided : Form
    {
        public static string alertString = "Toode  on lisatud ostukorvi!";
        public static string path = @"..\..\..\Inventory.txt";
        public Riided()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string riie = System.Environment.NewLine + " Naiste pluus must, 20€";
            File.AppendAllText(path, riie);
            Ostja.Raha -= 20;
            alert.Text = alertString + " " + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string riie2 = System.Environment.NewLine + "Meeste pluus (valik), 27€";
            File.AppendAllText(path, riie2);
            Ostja.Raha -= 27;
            alert.Text = alertString + " " + button2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string riie3 = System.Environment.NewLine + " Meeste teksad, 39€";
            File.AppendAllText(path, riie3);
            Ostja.Raha -= 39;
            alert.Text = alertString + " " + button4.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string riie4 = System.Environment.NewLine + " Naiste pluus roosa, 25€";
            File.AppendAllText(path, riie4);
            Ostja.Raha -= 25;
            alert.Text = alertString + " " + button3.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string riie5 = System.Environment.NewLine + " Naiste pluus pitsiline, 30€";
            File.AppendAllText(path, riie5);
            Ostja.Raha -= 30;
            alert.Text = alertString + " " + button5.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string riie6 = System.Environment.NewLine + " Naiste pluus valge, 28€";
            File.AppendAllText(path, riie6);
            Ostja.Raha -= 28;
            alert.Text = alertString + " " + button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string riie7 = System.Environment.NewLine + " Naiste teksad, 35€";
            File.AppendAllText(path, riie7);
            Ostja.Raha -= 35;
            alert.Text = alertString + " " + button9.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string riie8 = System.Environment.NewLine + " Tüdrukute pluus punane pitsidega, 12€";
            File.AppendAllText(path, riie8);
            Ostja.Raha -= 12;
            alert.Text = alertString + " " + button8.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string riie9 = System.Environment.NewLine + " Käekott must, 35€";
            File.AppendAllText(path, riie9);
            Ostja.Raha -= 35;
            alert.Text = alertString + " " + button7.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string riie10 = System.Environment.NewLine + " Meeste pluus (valik), 32€";
            File.AppendAllText(path, riie10);
            Ostja.Raha -= 32;
            alert.Text = alertString + " " + button6.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Toit s = new Toit();
            s.ShowDialog();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            Process.Start(@"");
            
           

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tehnika t = new Tehnika();
            t.ShowDialog();
            this.Close();
        }

        private void Riided_Load(object sender, EventArgs e)
        {

        }

        private void Algusesse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();

        }
    }
}
