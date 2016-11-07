using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Basic_G03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "G03_Collection";
        }

        private void Wuerfelnbutton_Click(object sender, EventArgs e)
        {
            #region Ankegen der Variablen
            double anz_eins = 0;
            double anz_zwei = 0;
            double anz_drei = 0;
            double anz_vier = 0;
            double anz_fuenf = 0;
            double anz_sechs = 0;

            Collection<int> zahlen = new Collection<int>();
            Random rnd = new Random();
            #endregion

            for (int i = 0; i < 1000000; i++)
            {
                //Erzeugen einer Zufallszahl von 1 bis 6 und Hinzufügen zur Collection "zahlen"
                zahlen.Add(rnd.Next(1,7));
            }

            #region Auswertung
            anz_eins = zahlen.Count(item => item == 1);
            anz_zwei = zahlen.Count(item => item == 2);
            anz_drei = zahlen.Count(item => item == 3);
            anz_vier = zahlen.Count(item => item == 4);
            anz_fuenf = zahlen.Count(item => item == 5);
            anz_sechs = zahlen.Count(item => item == 6);
            #endregion

            #region Ausgabe
            eins_abs.Text = anz_eins.ToString();            
            eins_rel.Text = (anz_eins / 1000000 * 100).ToString();

            zwei_abs.Text = anz_zwei.ToString();
            zwei_rel.Text = (anz_zwei / 1000000 * 100).ToString();

            drei_abs.Text = anz_drei.ToString();
            drei_rel.Text = (anz_drei / 1000000 * 100).ToString();

            vier_abs.Text = anz_vier.ToString();
            vier_rel.Text = (anz_vier / 1000000 * 100).ToString();

            fuenf_abs.Text = anz_fuenf.ToString();
            fuenf_rel.Text = (anz_fuenf / 1000000 * 100).ToString();

            sechs_abs.Text = anz_sechs.ToString();
            sechs_rel.Text = (anz_sechs / 1000000 * 100).ToString();
            #endregion
        }
    }
}
