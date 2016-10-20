using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Basic_G05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFile.InitialDirectory = Environment.CurrentDirectory;
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(OpenFile.FileName);
                AusgabeBox.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if(ColorDialog.ShowDialog() == DialogResult.OK)
            {
                AusgabeBox.ForeColor = ColorDialog.Color;
            }
        }
    }
}
