using System;
using System.Collections.Generic;
using System.Drawing;
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


        public string GetCarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Informacion del Auto dentro del Garage");
            sb.AppendLine($"Modelo: {modelo.ToString()}");
            sb.AppendLine($"Patente: {patente.ToString()}");
           
            return sb.ToString();
        }
    }
}
