using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class SeeOnKassa : Form

    {
        public static string alertString = "Toode  on lisatud ostukorvi!";
        public static string path = @"..\..\..\Inventory.txt";
        public SeeOnKassa()
        {
            InitializeComponent();
        }

        private void kommid_Click(object sender, EventArgs e)
        {
            string kassa1 = System.Environment.NewLine + " Hapud kommid BRAIN BLASTERZ, BBB, 48g 2€";
            File.AppendAllText(path, kassa1);
            Ostja.Raha -= 2;
            Ostja.Summa += 2;
            alert.Text = alertString + " " + kommid.Text;

        }

        private void salvratik_Click(object sender, EventArgs e)
        {
            string kassa2 = System.Environment.NewLine + "Niisked salvrätikud Pure, HUGGIES, 4x56tk 3€";
            File.AppendAllText(path, kassa2);
            Ostja.Raha -= 3;
            Ostja.Summa += 3;
            alert.Text = alertString + " " + salvratik.Text;
        }
        
        private void kilekott_Click(object sender, EventArgs e)
        {
            string kassa3 = System.Environment.NewLine + "Kilekotid sangadega, läbip. 5L, MCLEAN, 40tk 2€";
            File.AppendAllText(path, kassa3);
            Ostja.Raha -= 2;
            Ostja.Summa += 2;
            alert.Text = alertString + " " + kilekott.Text;
        }

        private void puuviljakommid_Click(object sender, EventArgs e)
        {
            string kassa4 = System.Environment.NewLine + "Puuviljakommid Lotte, MAIASMOKK, 16g 1€";
            File.AppendAllText(path, kassa4);
            Ostja.Raha -= 1;
            Ostja.Summa += 1;
            alert.Text = alertString + " " + puuviljakommid.Text;
        }

        private void musli_Click(object sender, EventArgs e)
        {
            string kassa5 = System.Environment.NewLine + "Müslibatoon šokolaadi-banaani, CORNY, 6x25g 2€";
            File.AppendAllText(path, kassa5);
            Ostja.Raha -= 2;
            Ostja.Summa += 2;
            alert.Text = alertString + " " + musli.Text;
        }

        private void tikud_Click(object sender, EventArgs e)
        {
            string kassa6 = System.Environment.NewLine + "Tuletikud, 10tk kiles, SELVER 1€";
            File.AppendAllText(path, kassa6);
            Ostja.Raha -= 1;
            Ostja.Summa += 1;
            alert.Text = alertString + " " + tikud.Text;
        }

        private void sipsid_Click(object sender, EventArgs e)
        {
            string kassa7 = System.Environment.NewLine + "Sinise kartuli krõpsud, TERRA, 110g 4€";
            File.AppendAllText(path, kassa7);
            Ostja.Raha -= 4;
            Ostja.Summa += 4;
            alert.Text = alertString + " " + sipsid.Text;
        }

        private void jäätis_Click(object sender, EventArgs e)
        {
            string kassa8 = System.Environment.NewLine + "Jäätis Classic, MAGNUM, 297g 7€";
            File.AppendAllText(path, kassa8);
            Ostja.Raha -= 7;
            Ostja.Summa += 7;
            alert.Text = alertString + " " + jäätis.Text;
        }

        private void vesi_Click(object sender, EventArgs e)
        {
            string kassa9= System.Environment.NewLine + "Naturaalne vesi, SAAREMAA, 5L 2€";
            File.AppendAllText(path, kassa9);
            Ostja.Raha -= 2;
            Ostja.Summa += 2;
            alert.Text = alertString + " " + vesi.Text;
        }

        private void kuunlad_Click(object sender, EventArgs e)
        {
            string kassa10 = System.Environment.NewLine + "Säraküünlad süda, LINDERS/KARIBOO, 4tk 5€";
            File.AppendAllText(path, kassa10);
            Ostja.Raha -= 3;
            Ostja.Summa += 3;
            alert.Text = alertString + " " + kuunlad.Text;
        }

        private void alert_Click(object sender, EventArgs e)
        {

        }
        public static string path2;
        private void Maksa_Click(object sender, EventArgs e)
        {
            if (Ostja.Raha >= 0)
            {
                label1.Text = "Kaup on edukalt ostetud! Siin on tsekk: ";
                path2 = @"../../../Tsekk.txt";
                File.Delete(path2);
                File.Copy(path, path2, true);
                var lines = File.ReadAllLines(path);
                lines[0] = "Ostetud kaup on: " + System.Environment.NewLine;
                File.WriteAllLines(path2, lines);
                string co = System.Environment.NewLine + "Ostu kogusumma oli: " + Ostja.Summa + "€";
                File.AppendAllText(path2, co);
                Process p = new Process();
                Process.Start(@"..\..\..\Tsekk.txt");
                p.Close();
            }
            else if(Ostja.Raha < 0)
            {
                label1.Text = "Sul ei ole piisabvalt raha selle eest maksmiseks!";
            }
        }

        private void Raha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kassa4 = System.Environment.NewLine + "Puuviljakommid Lotte, MAIASMOKK, 16g 1€";
            string text = File.ReadAllText(path);
            text = text.Replace(kassa4, " ");
            File.WriteAllText(path, text);
            if (kassa4 == text)
            {
                Ostja.Raha += 1;
                Ostja.Summa -= 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kassa9 = System.Environment.NewLine + "Naturaalne vesi, SAAREMAA, 5L 2€";
            string text = File.ReadAllText(path);
            text = text.Replace(kassa9, " ");
            File.WriteAllText(path, text);
            if (kassa9 == text)
            {
                Ostja.Raha += 2;
                Ostja.Summa -= 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kassa6 = System.Environment.NewLine + "Tuletikud, 10tk kiles, SELVER 1€";
            string text = File.ReadAllText(path);
            text = text.Replace(kassa6, " ");
            File.WriteAllText(path, text);
            if (kassa6 == text)
            {
                Ostja.Raha += 1;
                Ostja.Summa -= 1;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kassa1 = System.Environment.NewLine + " Hapud kommid BRAIN BLASTERZ, BBB, 48g 2€";
            string text = File.ReadAllText(path);
            text = text.Replace(kassa1, " ");
            File.WriteAllText(path, text);
            if (kassa1 == text)
            {
                Ostja.Raha += 2;
                Ostja.Summa -= 2;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string kassa2 = System.Environment.NewLine + "Niisked salvrätikud Pure, HUGGIES, 4x56tk 3€";
            string text = File.ReadAllText(path);
            text = text.Replace(kassa2, " ");
            File.WriteAllText(path, text);
            if (kassa2 == text)
            {
                Ostja.Raha += 3;
                Ostja.Summa -= 3;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string kassa7 = System.Environment.NewLine + "Sinise kartuli krõpsud, TERRA, 110g 4€";
            string text = File.ReadAllText(path);
            text = text.Replace(kassa7, " ");
            File.WriteAllText(path, text);
            if (kassa7 == text)
            {
                Ostja.Raha += 4;
                Ostja.Summa -= 4;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string kassa3 = System.Environment.NewLine + "Kilekotid sangadega, läbip. 5L, MCLEAN, 40tk 2€";
            string text = File.ReadAllText(path);
            text = text.Replace(kassa3, " ");
            File.WriteAllText(path, text);
            if (kassa3 == text)
            {
                Ostja.Raha += 2;
                Ostja.Summa -= 2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string kassa8 = System.Environment.NewLine + "Jäätis Classic, MAGNUM, 297g 7€";
            string text = File.ReadAllText(path);
            text = text.Replace(kassa8, " ");
            File.WriteAllText(path, text);
            if (kassa8 == text)
            {
                Ostja.Raha += 7;
                Ostja.Summa -= 7;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string kassa5 = System.Environment.NewLine + "Müslibatoon šokolaadi-banaani, CORNY, 6x25g 2€";
            string text = File.ReadAllText(path);
            text = text.Replace(kassa5, " ");
            File.WriteAllText(path, text);
            if (kassa5 == text)
            {
                Ostja.Raha += 2;
                Ostja.Summa -= 2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string kassa10 = System.Environment.NewLine + "Säraküünlad süda, LINDERS/KARIBOO, 4tk 5€";
            string text = File.ReadAllText(path);
            text = text.Replace(kassa10, " ");
            File.WriteAllText(path, text);
            if (kassa10 == text)
            {
                Ostja.Raha += 5;
                Ostja.Summa -= 5;
            }
        }
    }
}
