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
    public partial class Manguasjad : Form
    {
        public static string alertString = "Toode  on lisatud ostukorvi!";
        public static string path = @"..\..\..\Inventory.txt";
        public Manguasjad()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 14;
            string lelu2 = System.Environment.NewLine + "MYSTERY Ajalooline mõõk 14€";
            File.AppendAllText(path, lelu2);
            alert.Text = alertString + " " + button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 20;
            string lelu3 = System.Environment.NewLine + "JAKKS Real Constuctions SUUR TÖÖKODA 20€ ";
            File.AppendAllText(path, lelu3);
            alert.Text = alertString + " " + button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 15;
            string lelu1 = System.Environment.NewLine + "MGA Bratz Selfie pulk nukuga 15€";
            File.AppendAllText(path, lelu1);
            alert.Text = alertString + " " + button8.Text;
        }

        private void Kõrin_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 23;
            string lelu4 = System.Environment.NewLine + "CHICCO Voodikõrin Punamütsike 23€";
            File.AppendAllText(path, lelu4);
            alert.Text = alertString + " " + Kõrin.Text;
        }

        private void rõngad_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 10;
            string lelu5 = System.Environment.NewLine + "CHICCO Rõngastest torn 10€ ";
            File.AppendAllText(path, lelu5);
            alert.Text = alertString + " " + rõngad.Text;
        }

        private void minion_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 19;
            string lelu6 = System.Environment.NewLine + "POSH PAWS MINIONS Pehme ükssarvik 19€ ";
            File.AppendAllText(path, lelu6);
            alert.Text = alertString + " " + minion.Text;
        }

        private void Karu_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 1;
            string lelu7 = System.Environment.NewLine + "Mingi Karu 1€ ";
            File.AppendAllText(path, lelu7);
            alert.Text = alertString + " " + Karu.Text;
        }

        private void spinner_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 9;
            string lelu8 = System.Environment.NewLine + "FOCO Spinner Batman 9€ ";
            File.AppendAllText(path, lelu8);
            alert.Text = alertString + " " + spinner.Text;
        }

        private void pöder_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 18;
            string lelu9 = System.Environment.NewLine + "JANOD Põder 18€ ";
            File.AppendAllText(path, lelu9);
            alert.Text = alertString + " " + pöder.Text;
        }

        private void kotike_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 7;
            string lelu10 = System.Environment.NewLine + "SAMBRO LEGO JOKER Lõunakott 7€";
            File.AppendAllText(path, lelu10);
            alert.Text = alertString + " " + kotike.Text;
        }

        private void Algusesse_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void Tehnikasse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tehnika t = new Tehnika();
            t.ShowDialog();
            this.Close();
        }

        private void Toitudesse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Toit s = new Toit();
            s.ShowDialog();
            this.Close();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {

            Process p = new Process();
            Process.Start(@"..\..\Inventory.txt");
            p.Close();
        }
    }
}
