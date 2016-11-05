using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace W02_gpx
{
    public partial class Form1 : Form
    {
        List<string> breite = new List<string>();
        List<string> laenge = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            openfile_dialog.InitialDirectory = Environment.CurrentDirectory;
            if (openfile_dialog.ShowDialog() == DialogResult.OK)
            {
                FileStream Filestream = new FileStream(openfile_dialog.FileName, FileMode.Open, FileAccess.Read);
                pfadlabel.Text = Filestream.Name.ToString();
                XmlReader reader = XmlReader.Create(Filestream);
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "wpt"))
                    {
                        if (reader.HasAttributes)
                        {
                            breite.Add(reader.GetAttribute("lat"));
                            laenge.Add(reader.GetAttribute("lon"));
                        }
                    }
                }
                

                Filestream.Close();
            }            
           }       

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string item in breite)
            {
                breite_box.Text += item.ToString() + "\t";
            }
            foreach (string item in laenge)
            {
                laenge_box.Text += item.ToString() + "\t";
            }
        }
    }
}
