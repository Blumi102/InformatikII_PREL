using System;
using System.Drawing;
using System.Windows.Forms;

namespace Basic_G01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "G01_Forms";
            Eingabebox.Select();
        }

        private void Eingabebox_TextChanged(object sender, EventArgs e)
        {
            string eingabe = Eingabebox.Text;
            double zahl = 0.0;

            //Try-Catch zum Abfangen von Buchstabeneingaben
            try
            {
                zahl = Convert.ToDouble(eingabe);

                //if-Bedingung, um die Eingabe negativer Zahken zu vermeiden
                if (zahl < 0)
                {
                    Ausgabebox.ForeColor = Color.Red;
                    Ausgabebox.Text = "Bitte geben Sie eine positive Zahl ein!";
                }
                else
                {
                    Ausgabebox.ForeColor = Color.Green;
                    Ausgabebox.Text = Convert.ToString(Math.Sqrt(zahl));
                }
            }
            catch
            {
                Ausgabebox.ForeColor = Color.Red;
                Ausgabebox.Text = "Bitte geben Sie eine ZAHL ein!";
            }
        }
    }
}
