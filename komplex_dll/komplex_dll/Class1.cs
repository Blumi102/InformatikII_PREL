using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komplex_dll
{
    public class Komplex
    {
        public double real = 0;
        public double imag = 0;

        public static Komplex add_komplex(Komplex z1, Komplex z2)
        {
            Komplex z3 = new Komplex();
            z3.real = z1.real + z2.real;
            z3.imag = z1.imag + z2.imag;
            return z3;
        }
    }
    
}
