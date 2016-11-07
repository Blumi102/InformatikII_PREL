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
            this.Text = "W02_Wahlaufgabe gpx";
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            //Auswahl der gpx-Datei mittels FileDialog
            openfile_dialog.InitialDirectory = Environment.CurrentDirectory;
            if (openfile_dialog.ShowDialog() == DialogResult.OK)
            {
                FileStream Filestream = new FileStream(openfile_dialog.FileName, FileMode.Open, FileAccess.Read);
                pfadlabel.Text = Filestream.Name.ToString();
                XmlReader reader = XmlReader.Create(Filestream);

                while (reader.Read()) //Auslesen der gesamten Datei
                {
                    //Suche nach Elementen, die "wpt" heißen
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "wpt"))
                    {
                        if (reader.HasAttributes) //Hat das Element Attribute
                        {
                            breite.Add(reader.GetAttribute("lat")); //"lat"-Attribut in die Liste "breite" einfügen
                            laenge.Add(reader.GetAttribute("lon")); //"lon"-Attribut in die Liste "laenge" einfügen
                        }
                    }
                }
                

                Filestream.Close();
            }            
           }       

        private void button1_Click(object sender, EventArgs e)
        {
            //Ausgabe
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
