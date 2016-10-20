using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Basic_G06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button3.Enabled = false;
            x2.Visible = false;
            erg2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region Initialize Visibility
            Button2.Enabled = false;
            Button3.Enabled = true;

            a13.Visible = false;
            a23.Visible = false;
            a31.Visible = false;
            a32.Visible = false;
            a33.Visible = false;

            b13.Visible = false;
            b23.Visible = false;
            b31.Visible = false;
            b32.Visible = false;
            b33.Visible = false;

            c13.Visible = false;
            c23.Visible = false;
            c31.Visible = false;
            c32.Visible = false;
            c33.Visible = false;

            x3.Visible = false;
            x2.Visible = true;
            erg3.Visible = false;
            erg2.Visible = true;
            #endregion
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            #region Initialize Visibility
            Button3.Enabled = false;
            Button2.Enabled = true;
            a13.Visible = true;
            a23.Visible = true;
            a31.Visible = true;
            a32.Visible = true;
            a33.Visible = true;

            b13.Visible = true;
            b23.Visible = true;
            b31.Visible = true;
            b32.Visible = true;
            b33.Visible = true;

            c13.Visible = true;
            c23.Visible = true;
            c31.Visible = true;
            c32.Visible = true;
            c33.Visible = true;

            x3.Visible = true;
            x2.Visible = false;
            erg3.Visible = true;
            erg2.Visible = false;
            #endregion

            #region Clear Textboxes
            a13.Text = "";
            a23.Text = "";
            a31.Text = "";
            a32.Text = "";
            a33.Text = "";

            b13.Text = "";
            b23.Text = "";
            b31.Text = "";
            b32.Text = "";
            b33.Text = "";

            c13.Text = "";
            c23.Text = "";
            c31.Text = "";
            c32.Text = "";
            c33.Text = "";
            #endregion
        }

        private void ErgButton_Click(object sender, EventArgs e)
        {
            #region Initialize Variables
            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] c = new int[3, 3];

            a[0, 0] = Convert.ToInt32(a11.Text);
            a[0, 1] = Convert.ToInt32(a12.Text);
            a[1, 0] = Convert.ToInt32(a21.Text);
            a[1, 1] = Convert.ToInt32(a22.Text);
           
            b[0, 0] = Convert.ToInt32(b11.Text);
            b[0, 1] = Convert.ToInt32(b12.Text);
            b[1, 0] = Convert.ToInt32(b21.Text);
            b[1, 1] = Convert.ToInt32(b22.Text);
            
            if (Button3.Enabled == false)
            {
                a[0, 2] = Convert.ToInt32(a13.Text);
                a[1, 2] = Convert.ToInt32(a23.Text);
                a[2, 0] = Convert.ToInt32(a31.Text);
                a[2, 1] = Convert.ToInt32(a32.Text);
                a[2, 2] = Convert.ToInt32(a33.Text);

                b[0, 2] = Convert.ToInt32(b13.Text);
                b[1, 2] = Convert.ToInt32(b23.Text);
                b[2, 0] = Convert.ToInt32(b31.Text);
                b[2, 1] = Convert.ToInt32(b32.Text);
                b[2, 2] = Convert.ToInt32(b33.Text);
            }
            #endregion

            #region Berechnung der Ergebnismatrix
            for (int i = 0; i < 3; i++) //Initialisieren der Ergebnismatrix mit 0
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = 0;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, 2] * b[2, j] + a[i, 1] * b[1, j] + a[i, 0] * b[0, j];
                }
            }
            #endregion

            #region Ausgabe der Ergebnismatrix
            c11.Text = Convert.ToString(c[0, 0]);
            c12.Text = Convert.ToString(c[0, 1]);
            c13.Text = Convert.ToString(c[0, 2]);

            c21.Text = Convert.ToString(c[1, 0]);
            c22.Text = Convert.ToString(c[1, 1]);
            c23.Text = Convert.ToString(c[1, 2]);

            c31.Text = Convert.ToString(c[2, 0]);
            c32.Text = Convert.ToString(c[2, 1]);
            c33.Text = Convert.ToString(c[2, 2]);
            #endregion
        }
    }
}
