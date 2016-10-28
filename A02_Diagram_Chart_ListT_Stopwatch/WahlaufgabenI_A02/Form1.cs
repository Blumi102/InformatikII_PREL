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
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.ObjectModel;

namespace WahlaufgabenI_A02
{
    public partial class Form1 : Form
    {
        bool start = false; //Läuft die Zeitmessung?
        int durchlaufe = 0; // Anzahl der Durchläufe
        int ausserhalb = 0; // Anzahl der Zeiten außerhalb der Wertung
        Stopwatch timer = new Stopwatch();
        List<double> zeiten = new List<double>();
        Series data = new Series("Gestoppte Zeiten");

        double z = 0.0;

        public Form1()
        {
            InitializeComponent();

            //Diagramm leer zeichen
            for (double i = 2.4; i < 3.7; i = i + 0.1)
            {
                i = Math.Round(i, 1);
                data.Points.AddXY(i, 0);
            }
            ergebnis_chart.Series.Add(data);
        }

        private void Start_button_Click(object sender, EventArgs e)
        {

            if (start == false)
            {
                timer.Reset();
                timer.Start();
                Start_button.Text = "Stop";
                Start_button.BackColor = Color.Red;
                start = true;

            }
            else
            {
                Start_button.Text = "Start";
                Start_button.BackColor = Color.Green;
                start = false;
                durchlaufe++;
                timer.Stop();

                //Auswertung
                z = timer.ElapsedMilliseconds;
                durchlaufe_label.Text = durchlaufe.ToString();
                Zeit_label.Text = Convert.ToString(z);

                double z_round = Math.Round(z / 1000, 1);
                if ((z_round < 2.4) || (z_round > 3.6))
                {
                    ausserhalb++;
                    aussen_label.Text = ausserhalb.ToString();
                }
                else
                {
                    zeiten.Add(z_round);
                }
                
                ergebnis_chart.Series.Clear();
               
                for (double i = 2.4; i < 3.7; i = i + 0.1)
                {
                    i = Math.Round(i, 1);
                    z = zeiten.Count(item => item == i);
                    data.Points.AddXY(i, z);
                }
                ergebnis_chart.Series.Add(data);
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            start = false; 
            durchlaufe = 0;
            ausserhalb = 0;

            durchlaufe_label.Text = durchlaufe.ToString();
            aussen_label.Text = ausserhalb.ToString();
            Zeit_label.Text = "0";

            ergebnis_chart.Series.Clear();
            data.Points.Clear();
            zeiten.Clear();

            for (double i = 2.4; i < 3.7; i = i + 0.1)
            {
                i = Math.Round(i, 1);
                data.Points.AddXY(i, 0);
            }
            ergebnis_chart.Series.Add(data);
        }
    }
}
