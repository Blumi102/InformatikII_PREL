using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace W06_user32.dll
{
    public partial class Form1 : Form
    {
        int r = 0;
        int g = 153;
        int b = 153;

        [DllImport("User32.dll")]
        static extern IntPtr GetDC(IntPtr pointer);


        public Form1()
        {
            InitializeComponent();
            this.Text = "W06_user32.dll";
        }

        static void Draw(Rectangle rectangle, Brush pinsel, IntPtr pointer) //Methode zum Zeichnen eines Rechtecks auf den Bildschirn
        {
            using (Graphics g = Graphics.FromHdc(pointer))
            {
                g.FillRectangle(pinsel, rectangle);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SolidBrush farbe = new SolidBrush(Color.FromArgb(255, r, g, b));

                int xpos = Convert.ToInt32(x_box.Text);
                int ypos = Convert.ToInt32(y_box.Text);
                int width = Convert.ToInt32(breite_box.Text);
                int height = Convert.ToInt32(hoehe_box.Text);

                
                bool active = true;
                while (active == true) //Verhindert, dass das Rechteck sofort wieder verschwindet
                {
                    Draw(new Rectangle(xpos, ypos, width, height), farbe , GetDC(IntPtr.Zero));
                    Thread.Sleep(1000);
                    active = false;
                }
            }
            catch
            {
                //Fängt falsche Eingaben ab
                MessageBox.Show("Bitte geben Sie in jedes Feld eine Integer-Zahl ein!", "Error");
            }                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Festlegen der Rechteckfarbe mittel ColorDialog
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Farbe_label.BackColor = colorDialog1.Color;
                r = colorDialog1.Color.R;
                g = colorDialog1.Color.G;
                b = colorDialog1.Color.B;
            }
        }
    }
}
