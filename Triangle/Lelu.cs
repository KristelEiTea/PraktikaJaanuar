using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikaJaanuar
{
    public partial class Lelu : Form
    {
        public Lelu()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 14;
            string lelu2 = System.Environment.NewLine + "MYSTERY Ajalooline mõõk 14€";
            FileDialog.AppendAllText(path, lelu2);
            alertString.Text = alertString + " " + button10.Text;

        }

        private void selfie_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 15;
            string lelu1 = System.Environment.NewLine + "MGA Bratz Selfie pulk nukuga 15€";
            FileDialog.AppendAllText(path, lelu1);
            alertString.Text = alertString + " " + selfie.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 20;
            string lelu3 = System.Environment.NewLine + "JAKKS Real Constuctions SUUR TÖÖKODA 20€ ";
            FileDialog.AppendAllText(path, lelu3);
            alertString.Text = alertString + " " + button9.Text;
        }

        private void Kõrin_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 23;
            string lelu4 = System.Environment.NewLine + "CHICCO Voodikõrin Punamütsike 23€";
            FileDialog.AppendAllText(path, lelu4);
            alertString.Text = alertString + " " + Kõrin.Text;
        }

        private void rõngad_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 10;
            string lelu5 = System.Environment.NewLine + "CHICCO Rõngastest torn 10€ ";
            FileDialog.AppendAllText(path, lelu5);
            alertString.Text = alertString + " " + rõngad.Text;
        }

        private void minion_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 19;
            string lelu6 = System.Environment.NewLine + "POSH PAWS MINIONS Pehme ükssarvik 19€ ";
            FileDialog.AppendAllText(path, lelu6);
            alertString.Text = alertString + " " + minion.Text;
        }

        private void Karu_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 1;
            string lelu7 = System.Environment.NewLine + "Mingi Karu 1€ ";
            FileDialog.AppendAllText(path, lelu7);
            alertString.Text = alertString + " " + Karu.Text;
        }

        private void spinner_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 9;
            string lelu8 = System.Environment.NewLine + "FOCO Spinner Batman 9€ ";
            FileDialog.AppendAllText(path, lelu8);
            alertString.Text = alertString + " " + spinner.Text;
        }

        private void pöder_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 18;
            string leluˇ9 = System.Environment.NewLine + "JANOD Põder 18€ ";
            FileDialog.AppendAllText(path, lelu9);
            alertString.Text = alertString + " " + pöder.Text;
        }

        private void kotike_Click(object sender, EventArgs e)
        {
            Ostja.Raha -= 7;
            string lelu10 = System.Environment.NewLine + "SAMBRO LEGO JOKER Lõunakott 7€";
            FileDialog.AppendAllText(path, lelu10);
            alertString.Text = alertString + " " + kotike.Text;
        }
    }
}
