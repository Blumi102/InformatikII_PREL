using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using komplex_dll;
using System.Numerics;

namespace Basic_G07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "G07_Komplex";
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            //Erzeugen dreier Zahlen der Klasse "Komplex", die in der dll beschrieben ist
            Komplex z1 = new Komplex();
            Komplex z2 = new Komplex();
            Komplex summe = new Komplex();

            //Wertzuweisung für die Real- und Imaginärteile
            z1.real = Convert.ToDouble(re1_box.Text);
            z1.imag = Convert.ToDouble(im1_box.Text);

            z2.real = Convert.ToDouble(re2_box.Text);
            z2.imag = Convert.ToDouble(im2_box.Text);

            //Addition und Ausgabe
            summe = Komplex.add_komplex(z1, z2);
            re_erg_label.Text = Convert.ToString(summe.real);
            im_erg_label.Text = Convert.ToString(summe.imag);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Erzeugen der Imaginär- und Realteile und Wertzuweisung
            double re1 = Convert.ToDouble(re1_box.Text);
            double im1 = Convert.ToDouble(im1_box.Text);
            double re2 = Convert.ToDouble(re2_box.Text);
            double im2 = Convert.ToDouble(im2_box.Text);

            //Erzeugen dreier Zahlen der Klasse "Complex"
            Complex z1 = new Complex(re1, im1);
            Complex z2 = new Complex(re2, im2);
            Complex summe = new Complex();

            //Addition und Ausgabe
            summe = Complex.Add(z1, z2);
            re_erg_label.Text = Convert.ToString(summe.Real);
            im_erg_label.Text = Convert.ToString(summe.Imaginary);
        }
    }
}
