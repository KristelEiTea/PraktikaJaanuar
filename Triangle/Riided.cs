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
            Ostja.Summa += 20;
            alert.Text = alertString + " " + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string riie2 = System.Environment.NewLine + "Meeste pluus (valik), 27€";
            File.AppendAllText(path, riie2);
            Ostja.Raha -= 27;
            Ostja.Summa += 27;
            alert.Text = alertString + " " + button2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string riie3 = System.Environment.NewLine + " Meeste teksad, 39€";
            File.AppendAllText(path, riie3);
            Ostja.Raha -= 39;
            Ostja.Summa += 39;
            alert.Text = alertString + " " + button4.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string riie4 = System.Environment.NewLine + " Naiste pluus roosa, 25€";
            File.AppendAllText(path, riie4);
            Ostja.Raha -= 25;
            Ostja.Summa += 25;
            alert.Text = alertString + " " + button3.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string riie5 = System.Environment.NewLine + " Naiste pluus pitsiline, 30€";
            File.AppendAllText(path, riie5);
            Ostja.Raha -= 30;
            Ostja.Summa += 30;
            alert.Text = alertString + " " + button5.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string riie6 = System.Environment.NewLine + " Naiste pluus valge, 28€";
            File.AppendAllText(path, riie6);
            Ostja.Raha -= 28;
            Ostja.Summa += 28;
            alert.Text = alertString + " " + button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string riie7 = System.Environment.NewLine + " Naiste teksad, 35€";
            File.AppendAllText(path, riie7);
            Ostja.Raha -= 35;
            Ostja.Summa += 35;
            alert.Text = alertString + " " + button9.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string riie8 = System.Environment.NewLine + " Tüdrukute pluus punane pitsidega, 12€";
            File.AppendAllText(path, riie8);
            Ostja.Raha -= 12;
            Ostja.Summa += 12;
            alert.Text = alertString + " " + button8.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string riie9 = System.Environment.NewLine + " Käekott must, 35€";
            File.AppendAllText(path, riie9);
            Ostja.Raha -= 35;
            Ostja.Summa += 35;
            alert.Text = alertString + " " + button7.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string riie10 = System.Environment.NewLine + " Meeste pluus (valik), 32€";
            File.AppendAllText(path, riie10);
            Ostja.Raha -= 32;
            Ostja.Summa += 32;
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
            this.Hide();
            SeeOnKassa k = new SeeOnKassa();
            k.ShowDialog();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            Process.Start(@"..\..\..\Inventory.txt");
            p.Close();


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

        private void button22_Click(object sender, EventArgs e)
        {
            string riie =  " Naiste pluus must, 20€";
            string text = File.ReadAllText(path);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == riie)
                {
                    Ostja.Raha += 20;
                    Ostja.Summa -= 20;
                }
            }
            text = text.Replace(riie, " ");
            File.WriteAllText(path, text);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string riie2 =  "Meeste pluus (valik), 27€";
            string text = File.ReadAllText(path);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == riie2)
                {
                    Ostja.Raha += 27;
                    Ostja.Summa -= 27;
                }
            }
            text = text.Replace(riie2, " ");
            File.WriteAllText(path, text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string riie3 =" Meeste teksad, 39€";
            string text = File.ReadAllText(path);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == riie3)
                {
                    Ostja.Raha += 39;
                    Ostja.Summa -= 39;
                }
            }
            text = text.Replace(riie3, " ");
            File.WriteAllText(path, text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string riie4 = " Naiste pluus roosa, 25€";
            string text = File.ReadAllText(path);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == riie4)
                {
                    Ostja.Raha += 25;
                    Ostja.Summa -= 25;
                }
            }
            text = text.Replace(riie4, " ");
            File.WriteAllText(path, text);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string riie5 = " Naiste pluus pitsiline, 30€";
            string text = File.ReadAllText(path);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == riie5)
                {
                    Ostja.Raha += 30;
                    Ostja.Summa -= 30;
                }
            }
            text = text.Replace(riie5, " ");
            File.WriteAllText(path, text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string riie6 = " Naiste pluus valge, 28€";
            string text = File.ReadAllText(path);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == riie6)
                {
                    Ostja.Raha += 28;
                    Ostja.Summa -= 28;
                }
            }
            text = text.Replace(riie6, " ");
            File.WriteAllText(path, text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string riie7 = " Naiste teksad, 35€";
            string text = File.ReadAllText(path);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == riie7)
                {
                    Ostja.Raha += 35;
                    Ostja.Summa -= 35;
                }
            }
            text = text.Replace(riie7, " ");
            File.WriteAllText(path, text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string riie8 = " Tüdrukute pluus punane pitsidega, 12€";
            string text = File.ReadAllText(path);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == riie8)
                {
                    Ostja.Raha += 12;
                    Ostja.Summa -= 12;
                }
            }
            text = text.Replace(riie8, " ");
            File.WriteAllText(path, text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string riie9 = " Käekott must, 35€";
            string text = File.ReadAllText(path);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == riie9)
                {
                    Ostja.Raha += 35;
                    Ostja.Summa -= 35;
                }
            }
            text = text.Replace(riie9, " ");
            File.WriteAllText(path, text);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string riie10 = " Meeste pluus (valik), 32€";
            string text = File.ReadAllText(path);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == riie10)
                {
                    Ostja.Raha += 32;
                    Ostja.Summa -= 32;
                }
            }
            text = text.Replace(riie10, " ");
            File.WriteAllText(path, text);
        }
    }
}
