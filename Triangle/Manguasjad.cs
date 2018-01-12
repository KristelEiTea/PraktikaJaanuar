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
            Ostja.Summa += 14;
            string lelu2 = System.Environment.NewLine + "MYSTERY Ajalooline mõõk 14€";
            File.AppendAllText(path, lelu2);
            alert.Text = alertString + " " + button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 20;
            Ostja.Summa += 20;
            string lelu3 = System.Environment.NewLine + "JAKKS Real Constuctions SUUR TÖÖKODA 20€ ";
            File.AppendAllText(path, lelu3);
            alert.Text = alertString + " " + button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 15;
            Ostja.Summa += 15;
            string lelu1 = System.Environment.NewLine + "MGA Bratz Selfie pulk nukuga 15€";
            File.AppendAllText(path, lelu1);
            alert.Text = alertString + " " + button8.Text;
        }

        private void Kõrin_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 23;
            Ostja.Summa += 23;
            string lelu4 = System.Environment.NewLine + "CHICCO Voodikõrin Punamütsike 23€";
            File.AppendAllText(path, lelu4);
            alert.Text = alertString + " " + Kõrin.Text;
        }

        private void rõngad_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 10;
            Ostja.Summa += 10;
            string lelu5 = System.Environment.NewLine + "CHICCO Rõngastest torn 10€ ";
            File.AppendAllText(path, lelu5);
            alert.Text = alertString + " " + rõngad.Text;
        }

        private void minion_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 19;
            Ostja.Summa += 19;
            string lelu6 = System.Environment.NewLine + "POSH PAWS MINIONS Pehme ükssarvik 19€ ";
            File.AppendAllText(path, lelu6);
            alert.Text = alertString + " " + minion.Text;
        }

        private void Karu_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 1;
            Ostja.Summa += 1;
            string lelu7 = System.Environment.NewLine + "Mingi Karu 1€ ";
            File.AppendAllText(path, lelu7);
            alert.Text = alertString + " " + Karu.Text;
        }


        private void spinner_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 9;
            Ostja.Summa += 9;
            string lelu8 = System.Environment.NewLine + "FOCO Spinner Batman 9€ ";
            File.AppendAllText(path, lelu8);
            alert.Text = alertString + " " + spinner.Text;
        }

        private void pöder_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 18;
            Ostja.Summa += 18;
            string lelu9 = System.Environment.NewLine + "JANOD Põder 18€ ";
            File.AppendAllText(path, lelu9);
            alert.Text = alertString + " " + pöder.Text;
        }

        private void kotike_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 7;
            Ostja.Summa += 7;
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
            Process.Start(@"..\..\..\Inventory.txt");
            p.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeeOnKassa k = new SeeOnKassa();
            k.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lelu6 = System.Environment.NewLine + "POSH PAWS MINIONS Pehme ükssarvik 19€ ";
            string text = File.ReadAllText(path);
            text = text.Replace(lelu6, " ");
            File.WriteAllText(path, text);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == lelu6)
                {
                    Ostja.Raha += 19;
                    Ostja.Summa -= 19;
                }
            }
            text = text.Replace(lelu6, " ");
            File.WriteAllText(path, text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lelu7 =  "Mingi Karu 1€ ";
            string text = File.ReadAllText(path);
            text = text.Replace(lelu7, " ");
            File.WriteAllText(path, text);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == lelu7)
                {
                    Ostja.Raha += 1;
                    Ostja.Summa -= 1;
                }
            }
            text = text.Replace(lelu7, " ");
            File.WriteAllText(path, text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string lelu2 =  "MYSTERY Ajalooline mõõk 14€";
            string text = File.ReadAllText(path);
            text = text.Replace(lelu2, " ");
            File.WriteAllText(path, text);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == lelu2)
                {
                    Ostja.Raha += 14;
                    Ostja.Summa -= 14;
                }
            }
            text = text.Replace(lelu2, " ");
            File.WriteAllText(path, text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string lelu3 =  "JAKKS Real Constuctions SUUR TÖÖKODA 20€ ";
            string text = File.ReadAllText(path);
            text = text.Replace(lelu3, " ");
            File.WriteAllText(path, text);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == lelu3)
                {
                    Ostja.Raha += 20;
                    Ostja.Summa -= 20;
                }
            }
            text = text.Replace(lelu3, " ");
            File.WriteAllText(path, text);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string lelu1 =  "MGA Bratz Selfie pulk nukuga 15€";
            string text = File.ReadAllText(path);
            text = text.Replace(lelu1, " ");
            File.WriteAllText(path, text);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == lelu1)
                {
                    Ostja.Raha += 15;
                    Ostja.Summa -= 15;
                }
            }
            text = text.Replace(lelu1, " ");
            File.WriteAllText(path, text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string lelu8 =  "FOCO Spinner Batman 9€ ";
            string text = File.ReadAllText(path);
            text = text.Replace(lelu8, " ");
            File.WriteAllText(path, text);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == lelu8)
                {
                    Ostja.Raha += 9;
                    Ostja.Summa -= 9;
                }
            }
            text = text.Replace(lelu8, " ");
            File.WriteAllText(path, text);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string lelu9 =  "JANOD Põder 18€ ";
            string text = File.ReadAllText(path);
            text = text.Replace(lelu9, " ");
            File.WriteAllText(path, text);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == lelu9)
                {
                    Ostja.Raha += 18;
                    Ostja.Summa -= 18;
                }
            }
            text = text.Replace(lelu9, " ");
            File.WriteAllText(path, text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string lelu4 =  "CHICCO Voodikõrin Punamütsike 23€";
            string text = File.ReadAllText(path);
            text = text.Replace(lelu4, " ");
            File.WriteAllText(path, text);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == lelu4)
                {
                    Ostja.Raha += 23;
                    Ostja.Summa -= 23;
                }
            }
            text = text.Replace(lelu4, " ");
            File.WriteAllText(path, text);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string lelu5 =  "CHICCO Rõngastest torn 10€ ";
            string text = File.ReadAllText(path);
            text = text.Replace(lelu5, " ");
            File.WriteAllText(path, text);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == lelu5)
                {
                    Ostja.Raha += 10;
                    Ostja.Summa -= 10;
                }
            }
            text = text.Replace(lelu5, " ");
            File.WriteAllText(path, text);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string lelu10 = "SAMBRO LEGO JOKER Lõunakott 7€";
            string text = File.ReadAllText(path);
            text = text.Replace(lelu10, " ");
            File.WriteAllText(path, text);
            string[] read = System.IO.File.ReadAllLines(path);
            foreach (string line in read)
            {
                if (line == lelu10)
                {
                    Ostja.Raha += 7;
                    Ostja.Summa -= 7;
                }
            }
            text = text.Replace(lelu10, " ");
            File.WriteAllText(path, text);

        }
    }
}

