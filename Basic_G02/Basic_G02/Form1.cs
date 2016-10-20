﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Basic_G02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Dezimalbruch = "";
            int zaehler = Convert.ToInt32(Zaehlerbox.Text);
            int nenner = Convert.ToInt32(Nennerbox.Text);

            Dezimalbruch += Convert.ToString(zaehler / nenner) + ".";

            for (int i = 1; i < 10001; i++)
            {
                zaehler = (zaehler % nenner)*10;
                Dezimalbruch += Convert.ToString(zaehler / nenner);
            }

            Ausgabebox.Text = Dezimalbruch;
        }
    }
}
