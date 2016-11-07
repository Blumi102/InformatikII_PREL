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
            this.Text = "G05_Dialoge";
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFile.InitialDirectory = Environment.CurrentDirectory; //Legt fest, dass beim Öffnen des FileDialogs zuerst der Pfad der .exe aufgerufen wird

            if (OpenFile.ShowDialog() == DialogResult.OK) //Anzeigen des FileDialogs
            {
                StreamReader sr = new StreamReader(OpenFile.FileName); //Zuweisen der ausgewählten Datei zu einem Stream
                AusgabeBox.Text = sr.ReadToEnd(); //Lesen der Datei und Ausgabe des Textes in der Ausgabe-Textbox
                sr.Close();
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if(ColorDialog.ShowDialog() == DialogResult.OK) //Anzeigen des ColorDialogs
            {
                AusgabeBox.ForeColor = ColorDialog.Color; //Setzen der Schriftfarbe der Textbox auf die ausgewählte Farbe
            }
        }
    }
}
