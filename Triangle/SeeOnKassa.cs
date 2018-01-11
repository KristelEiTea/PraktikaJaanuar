using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
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
                alert.Text = alertString + " " + kommid.Text;

        }

        private void salvratik_Click(object sender, EventArgs e)
        {

        }

        private void kilekott_Click(object sender, EventArgs e)
        {

        }

        private void puuviljakommid_Click(object sender, EventArgs e)
        {

        }

        private void musli_Click(object sender, EventArgs e)
        {

        }

        private void tikud_Click(object sender, EventArgs e)
        {

        }

        private void sipsid_Click(object sender, EventArgs e)
        {

        }

        private void jäätis_Click(object sender, EventArgs e)
        {

        }

        private void vesi_Click(object sender, EventArgs e)
        {

        }

        private void kuunlad_Click(object sender, EventArgs e)
        {

        }
    }
}
