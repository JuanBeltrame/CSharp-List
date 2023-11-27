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
        public int modelo;

        public Auto(string patente, string marca, int modelo)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
        }
    }
}
