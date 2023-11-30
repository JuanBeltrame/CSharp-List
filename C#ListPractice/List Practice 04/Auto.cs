using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice_04
{
    internal class Auto
    {
        int modelo;
        int patente;
        Color color;
        decimal cantKm;


        public Auto(int modelo, int patente, Color color, decimal cantidadKilometros)
        {
            this.modelo = modelo;
            this.patente = patente;
            this.color = color;
            cantKm = cantidadKilometros;
        }

        public string GetCarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Informacion del Auto dentro del Garage");
            sb.AppendLine($"Modelo: {modelo.ToString()}");
            sb.AppendLine($"Patente: {patente.ToString()}");
            sb.AppendLine($"Color: {color.ToString()}");
            sb.AppendLine($"Cantidad de Kilometos: {cantKm.ToString()}");

            return sb.ToString();
        }
    }
}
