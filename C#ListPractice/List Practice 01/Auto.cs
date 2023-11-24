using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice_01
{
    internal class Auto
    {
        private string patente;
        private string marca;
        public List<string> cosas;

        public Auto(string patente, string marca)
        {
            this.patente = patente;
            this.marca = marca;
        }
    }
}
