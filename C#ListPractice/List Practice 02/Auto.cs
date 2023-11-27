using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice_02
{
    internal class Auto
    {
        public string patente;
        public string color;
        public int dniDuenio;

        public Auto(string patente, int dniDue)
        {
            this.patente = patente;
            dniDuenio = dniDue;
        }

        public Auto(string pat, string col, int dniDuenio):this(pat, dniDuenio)
        {
            patente = pat;
            color = col;
            this.dniDuenio = dniDuenio;
        }
    }
}
