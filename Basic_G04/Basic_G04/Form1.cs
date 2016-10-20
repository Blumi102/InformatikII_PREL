using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Basic_G04
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();         
        }

        private void Zeichnen_Panel_Paint(object sender, PaintEventArgs e)
        {

            int ampl1 = 0;
            int w1 = 1;
            int ampl2 = 0;
            int w2 = 1;
          
            w1 = Wellenlaengen_slider1.Value;
            w2 = Wellenlaengen_slider2.Value;
            ampl1 = Amplitudenslider1.Value;
            ampl2 = Amplitudenslider2.Value;


            Collection<PointF> schwebung = new Collection<PointF>(); // Liste mit allen Punkten der Schwebung
            Graphics g = e.Graphics; ; //Grapgikobjekt anlegen
            g.TranslateTransform(0, 210); //Koordinatenursprung versetzen
            Pen pen_Schwebung = new Pen(Color.Red);
            Pen pen_Koordinatensystem = new Pen(Color.Black, 1);
            SolidBrush pen_Beschriftung = new SolidBrush(Color.Black);


            for (float i = 0F; i <Zeichnen_Panel.Width; i = i + 0.1F)
            {
                float y = (ampl1 * (float)Math.Sin(i*2*Math.PI/w1)) + (ampl2 * (float)Math.Sin(i * 2 * Math.PI / w2));
                schwebung.Add(new PointF(10*i, 10*y));
            }

            g.Clear(Color.White);
            g.DrawCurve(pen_Schwebung, schwebung.ToArray());

            g.DrawLine(pen_Koordinatensystem, -Zeichnen_Panel.Height, 0, Zeichnen_Panel.Width, 0);
            g.DrawLine(pen_Koordinatensystem, 0, -Zeichnen_Panel.Height, 0, Zeichnen_Panel.Width);

            for (int i = -Zeichnen_Panel.Height / 2; i < Zeichnen_Panel.Height / 2; i = i + 20)
            {
                g.DrawLine(pen_Koordinatensystem, -2, i, 2, i);
                g.DrawString(Convert.ToString(i / 10), this.Font, pen_Beschriftung, 10, -i - 7);
            }

            for (int i = -Zeichnen_Panel.Width; i < Zeichnen_Panel.Width; i = i + 10)
            {
                g.DrawLine(pen_Koordinatensystem, i, -2, i, 2);
            }
            
        }

       

        private void Amplitudenslider1_Scroll(object sender, EventArgs e)
        {
            ampl1_box.Text = Amplitudenslider1.Value.ToString();
            Zeichnen_Panel.Refresh();
        }

        private void Wellenlaengenslider1_Scroll(object sender, EventArgs e)
        {
            freq1_box.Text = (Wellenlaengen_slider1.Value).ToString();
            Zeichnen_Panel.Refresh();
        }

        private void Amplitudenslider2_Scroll(object sender, EventArgs e)
        {
            ampl2_box.Text = Amplitudenslider2.Value.ToString();
            Zeichnen_Panel.Refresh();
        }

        private void Wellenlaengenslider2_Scroll(object sender, EventArgs e)
        {
            freq2_box.Text = (Wellenlaengen_slider2.Value).ToString();
            Zeichnen_Panel.Refresh();
        }

       
    }
}
