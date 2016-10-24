using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace W06_user32.dll
{
   
    class Program
    {
        [DllImport("User32.dll)")]
        static extern IntPtr GetDC(IntPtr pointer);


        static void Draw (Rectangle rectangle, Brush pinsel, IntPtr pointer)
        {
            using (Graphics g = Graphics.FromHdc(pointer))
            {
                g.FillRectangle(pinsel, rectangle);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Command -> ");
            string cmd = Console.ReadLine();

            if (cmd.ToLower().Substring(0,4) == "draw")
            {
               string[] rec = cmd.Substring(5).Split(':');
               int xpos = Convert.ToInt32(rec[0]);
               int ypos = Convert.ToInt32(rec[1]);
               int width = Convert.ToInt32(rec[2]);
               int height = Convert.ToInt32(rec[3]);

               Draw(new Rectangle(xpos, ypos, width, height), Brushes.Beige, GetDC(IntPtr.Zero));

            }

        }
    }
}
