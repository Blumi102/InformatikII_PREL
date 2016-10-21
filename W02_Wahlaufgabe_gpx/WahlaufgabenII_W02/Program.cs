using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WahlaufgabenII_W02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> breite = new List<string>();
            List<string> laenge = new List<string>();

            XmlReader reader = XmlReader.Create("C:\\Users\\Michelle\\Dropbox\\DH\\3. Semester\\Info\\Programme\\PREL\\WahlaufgabenII_W02\\WahlaufgabenII_W02\\RouteVonWeststraße8NachAmHohenStein21Karlsruhe.gpx");
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
            foreach (string item in breite)
                {
                Console.WriteLine(item);
                }
            Console.Read();
            }           
        }
    }

