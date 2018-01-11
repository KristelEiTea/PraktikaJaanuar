using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    static class Program
    {
        public static string path = @"../../../Inventory.txt";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            path = @"../../../Inventory.txt";
            File.Delete(path);
            string tekst = "Ostukorvis on: ";
            File.AppendAllText(path, tekst);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Checkbox());
        }
    }
}
