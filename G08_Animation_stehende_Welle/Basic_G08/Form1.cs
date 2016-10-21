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
        int aktuelle_Zeit=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void zeichnen_Panel_Paint(object sender, PaintEventArgs e)
        {
            int ampl = 0;
            int w = 1;

            w = Frequenz_slider.Value;
            ampl = Amplituden_slider.Value;


            Collection<PointF> welle = new Collection<PointF>(); // Liste mit allen Punkten der Schwebung
            Graphics g = e.Graphics; ; //Grapgikobjekt anlegen
            g.TranslateTransform(0, zeichnen_Panel.Height/2); //Koordinatenursprung versetzen
            Pen pen_Welle = new Pen(Color.Red);
            Pen pen_Koordinatensystem = new Pen(Color.Black, 1);
            SolidBrush Brush_Beschriftung = new SolidBrush(Color.Black);


            for (float i = 0F; i < zeichnen_Panel.Width; i = i + 0.1F)
            {
                float y = ampl * (float)Math.Sin(2 * Math.PI * (Frequenz_slider.Value * aktuelle_Zeit + i / Wellenlaengen_slider.Value));
                //float y = (ampl1 * (float)Math.Sin(i * 2 * Math.PI / w1)) + (ampl2 * (float)Math.Sin(i * 2 * Math.PI / w2));
                welle.Add(new PointF(10 * i, 10 * y));
            }

            g.Clear(Color.White);
            g.DrawCurve(pen_Welle, welle.ToArray());

            g.DrawLine(pen_Koordinatensystem, -zeichnen_Panel.Height, 0, zeichnen_Panel.Width, 0);
            g.DrawLine(pen_Koordinatensystem, 0, -zeichnen_Panel.Height, 0, zeichnen_Panel.Width);

            for (int i = -zeichnen_Panel.Height / 2; i < zeichnen_Panel.Height / 2; i = i + 20)
            {
                g.DrawLine(pen_Koordinatensystem, -2, i, 2, i);
                g.DrawString(Convert.ToString(i / 10), this.Font, Brush_Beschriftung, 10, -i - 7);
            }

            for (int i = -zeichnen_Panel.Width; i < zeichnen_Panel.Width; i = i + 10)
            {
                g.DrawLine(pen_Koordinatensystem, i, -2, i, 2);
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //aktuelle_Zeit++;                    
            //zeichnen_Panel.Refresh();
        }
    }
}
