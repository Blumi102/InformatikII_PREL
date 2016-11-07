using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_G08
{
    public partial class Form1 : Form
    {
        double phi = 0;     

        public Form1()
        {
            InitializeComponent();
            this.Text = "G08_Animation stehende Welle";
            this.DoubleBuffered = true; //buffert die Bildpunkte vor der Ausgabe -> flüssigere Animation
            Zeit_t.Start(); //Start des Timers
        }

        private void zeichnen_Panel_Paint(object sender, PaintEventArgs e)
        {

            int ampl = 0;
            int w = 1;

            this.DoubleBuffered = true;

            w = Frequenz_slider.Value / 3;
            ampl = Amplituden_slider.Value;

            //Erzegen von Collections für die 2 überlagerten und die Ergebniswelle
            Collection<PointF> welle = new Collection<PointF>(); // Liste mit allen Punkten der Welle
            Collection<PointF> welle1 = new Collection<PointF>(); // Liste mit allen Punkten der Welle1
            Collection<PointF> welle2 = new Collection<PointF>(); // Liste mit allen Punkten der Welle2

            Graphics g = e.Graphics; ; //Grapgikobjekt anlegen
            g.TranslateTransform(0, zeichnen_Panel.Height / 2); //Koordinatenursprung versetzen

            //Anlegen der verschiedenen "Stifte"
            Pen Pen_Welle = new Pen(Color.Red);
            Pen Pen_Teilwelle = new Pen(Color.Black);
            Pen pen_Koordinatensystem = new Pen(Color.Black, 1);
            SolidBrush Brush_Beschriftung = new SolidBrush(Color.Black);


            for (float i = 0F; i < zeichnen_Panel.Width; i = i + 0.1F)
            {
                //Berechnung der 3 Wellen
                float y = (float)ampl * ((float)Math.Sin(w * (i - phi)) + (float)Math.Sin(w * (i + phi)));
                float y1 = (float)ampl * ((float)Math.Sin(w * (i - phi)));
                float y2 = (float)ampl * ((float)Math.Sin(w * (i + phi)));

                //Hinzufügen der Werte zu den entsprechenden Collections
                welle.Add(new PointF(10 * i, 10 * y));
                welle1.Add(new PointF(10 * i, 10 * y1));
                welle2.Add(new PointF(10 * i, 10 * y2));

            }

            g.Clear(Color.White); //Bereinigen der Zeichenfläche
            //Zeichnen der 3 Wellen
            g.DrawCurve(Pen_Welle, welle.ToArray());
            g.DrawCurve(Pen_Teilwelle, welle1.ToArray());
            g.DrawCurve(Pen_Teilwelle, welle2.ToArray());

            ////Zeichnen des Koordinatensystems
            //g.DrawLine(pen_Koordinatensystem, -zeichnen_Panel.Height, 0, zeichnen_Panel.Width, 0);
            //g.DrawLine(pen_Koordinatensystem, 0, -zeichnen_Panel.Height, 0, zeichnen_Panel.Width);

            //for (int i = -zeichnen_Panel.Height / 2; i < zeichnen_Panel.Height / 2; i = i + 20)
            //{
            //    g.DrawLine(pen_Koordinatensystem, -2, i, 2, i);
            //    g.DrawString(Convert.ToString(i / 10), this.Font, Brush_Beschriftung, 10, -i - 7);
            //}

            //for (int i = -zeichnen_Panel.Width; i < zeichnen_Panel.Width; i = i + 10)
            //{
            //    g.DrawLine(pen_Koordinatensystem, i, -2, i, 2);
            //}

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Mit jedem "Tick" des Timers wird der Winkel Phi erhöht und die Zeichenfläche aktualisiert
            phi = phi + 0.3;
            zeichnen_Panel.Refresh();
        }

        private void Amplituden_slider_Scroll(object sender, EventArgs e) //Änderung der Amplitude
        {
            zeichnen_Panel.Refresh();
        }

        private void Frequenz_slider_Scroll(object sender, EventArgs e) //Änderung der Frequenz
        {
            zeichnen_Panel.Refresh();
        }
    }
}
