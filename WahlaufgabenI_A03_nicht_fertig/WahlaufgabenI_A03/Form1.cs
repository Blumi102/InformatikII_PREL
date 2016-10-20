using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WahlaufgabenI_A03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert_button_Click(object sender, EventArgs e)
        {
            Bitmap ergebnis = new Bitmap(pic1_box.Image);
            for (int i = 0; i < 255; i++)
            {
                for (int j = 0; i < 255; i++)
                {
                    Bitmap pic1 = new Bitmap(pic1_box.Image);
                    Color pixelcolor1 = pic1.GetPixel(i, j);
                    int r = pixelcolor1.R;
                    int g = pixelcolor1.G;
                    int b = pixelcolor1.B;

                    Bitmap pic2 = new Bitmap(pic2_box.Image);
                    Color pixelcolor2 = pic2.GetPixel(i, j);

                    if (!(g > r))
                    {
                        ergebnis.SetPixel(i, j, pixelcolor1);
                    }
                    else
                    {
                        ergebnis.SetPixel(i, j, pixelcolor2);
                    }
                }
            }
            erg_box.Image = ergebnis;
        }

        private void pic1_button_Click(object sender, EventArgs e)
        {
            select_pic_dialog.InitialDirectory = Environment.CurrentDirectory;
            if (select_pic_dialog.ShowDialog() == DialogResult.OK)
            {
                pic1_box.SizeMode = PictureBoxSizeMode.StretchImage;
                FileStream Imagestream = new FileStream(select_pic_dialog.FileName, FileMode.Open, FileAccess.Read);
                pic1_box.Image = System.Drawing.Image.FromStream(Imagestream);
                Imagestream.Close();        
            }
        }

        private void pic2_button_Click(object sender, EventArgs e)
        {
            select_pic_dialog.InitialDirectory = Environment.CurrentDirectory;
            if (select_pic_dialog.ShowDialog() == DialogResult.OK)
            {
                pic2_box.SizeMode = PictureBoxSizeMode.StretchImage;
                FileStream Imagestream = new FileStream(select_pic_dialog.FileName, FileMode.Open, FileAccess.Read);
                pic2_box.Image = System.Drawing.Image.FromStream(Imagestream);
                Imagestream.Close();
            }
        }
    }
}
