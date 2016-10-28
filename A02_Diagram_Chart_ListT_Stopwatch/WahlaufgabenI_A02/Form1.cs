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

namespace WahlaufgabenI_A02
{
    public partial class Form1 : Form
    {
        bool start = false; //Läuft die Zeitmessung?
        int durchlaufe = 0; // Anzahl der Durchläufe
        int ausserhalb = 0; // Anzahl der Zeiten außerhalb der Wertung
        Stopwatch timer = new Stopwatch();
        List<double> zeiten = new List<double>();
        

        double z = 0.0;

        public Form1()
        {
            InitializeComponent();        
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

                zeiten.Add(Math.Round(z / 1000, 1));       
                
                ergebnis_chart.Series.Clear();

                Series data = new Series("Gestoppte Zeiten");
                for (double i = 2.4; i < 3.7; i = i + 0.1)
                {
                    data.Points.AddXY(i, zeiten.Count(item => item == i));
                }
                ergebnis_chart.Series.Add(data);
            }
        }
    }
}
