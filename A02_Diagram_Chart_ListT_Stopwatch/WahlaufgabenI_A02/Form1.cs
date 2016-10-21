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

namespace WahlaufgabenI_A02
{
    public partial class Form1 : Form
    {
        bool start = false; //Läuft die Zeitmessung?
        int durchlaufe = 0; // Anzahl der Durchläufe
        int ausserhalb = 0; // Anzahl der Zeiten außerhalb der Wertung
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            List<double> zeiten = new List<double>();
            
           

            //my_w.Reset();

            if (start == false)
            {
                Start_button.Text = "Stop";
                Start_button.BackColor = Color.Red;
                start = true;
                timer.Start();
            }
            else
            {
                Start_button.Text = "Start";
                Start_button.BackColor = Color.Green;
                start = false;
                durchlaufe++;
                timer.Stop();
                double z = timer.ElapsedMilliseconds;

                durchlaufe_label.Text = durchlaufe.ToString();
                Zeit_label.Text = Convert.ToString(z);

            }
        }
    }
}
