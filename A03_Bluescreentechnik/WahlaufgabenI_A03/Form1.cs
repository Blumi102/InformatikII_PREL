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
           
            int h = 0;
            int w = 0;

            Bitmap pic2 = new Bitmap(pic2_box.Image);
            if (pic2_box.Image.Width > pic2_box.Image.Height)
            {
                if (pic1_box.Image.Width > pic2_box.Image.Width)
                {
                    double w2 = Convert.ToDouble(pic2_box.Image.Width);
                    double w1 = Convert.ToDouble(pic1_box.Image.Width);
                    double verkleinerung =  w2/w1 ;

                    h = Convert.ToInt32(pic1_box.Image.Height * verkleinerung);
                    w = pic2_box.Image.Width;
                }
            }
            else
            {
                if (pic1_box.Image.Height > pic2_box.Image.Height)
                {
                    double verkleinerung = pic2_box.Image.Height / pic1_box.Image.Height;
                    //w = Convert.ToInt32(pic1_box.Image.Width * verkleinerung);
                    h = pic2_box.Image.Height;
                }
            }


            if (h > pic2.Height)
            {
                double verkleinerung = pic2.Height / h;
                w = w * Convert.ToInt32(verkleinerung);
                h = pic2.Height;

            }

            if (w > pic2.Width)
            {
                double verkleinerung = pic2.Width / w;
                h = h * Convert.ToInt32(verkleinerung);
                w = pic2.Width;

            }

            Bitmap pic1 = new Bitmap(pic1_box.Image, w, h);
            

            Bitmap ergebnis = new Bitmap(pic2_box.Image);

            for (int i = 0; i < pic2.Width; i++)
            {
                for (int j = 0; j < pic2.Height; j++)
                {
                    if ((i < pic1.Width) && (j < pic1.Height))
                    {
                        Color pixelcolor1 = pic1.GetPixel(i, j);
                        int r = pixelcolor1.R;
                        int g = pixelcolor1.G;
                        int b = pixelcolor1.B;

                        Color pixelcolor2 = pic2.GetPixel(i, j);
                                          
                        if (!(g - r > 35 && g - b > 35))
                        {
                            ergebnis.SetPixel(i, j, pixelcolor1);
                        }
                    }  
                    else
                    {

                    }     
                }
            }
            erg_box.SizeMode = PictureBoxSizeMode.Zoom;
            erg_box.Image = ergebnis;
        }

        private void pic1_button_Click(object sender, EventArgs e)
        {
            select_pic_dialog.InitialDirectory = Environment.CurrentDirectory;
            if (select_pic_dialog.ShowDialog() == DialogResult.OK)
            {
                pic1_box.SizeMode = PictureBoxSizeMode.Zoom;
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
                pic2_box.SizeMode = PictureBoxSizeMode.Zoom;
                FileStream Imagestream = new FileStream(select_pic_dialog.FileName, FileMode.Open, FileAccess.Read);
                pic2_box.Image = System.Drawing.Image.FromStream(Imagestream);
                Imagestream.Close();
            }
        }
    }
}
