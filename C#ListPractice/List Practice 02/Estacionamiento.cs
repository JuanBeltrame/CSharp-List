using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice_02
{
    internal class Estacionamiento
    {
        private List<Auto> listaAutos;
        private int capacidadEstacionamiento;


        public Estacionamiento(int capacidad)
        {
            listaAutos = new List<Auto>();
            this.capacidadEstacionamiento = capacidad;
        }

        public int CapacidadEstacionamiento { get => capacidadEstacionamiento; set => capacidadEstacionamiento = value; }



        public string IngresarAuto(Auto auxAuto)
        {
            if (capacidadEstacionamiento <= listaAutos.Count())
            {
                return "Error, Estacionamiento Completo";
            }
            else
            {
                listaAutos.Add(auxAuto);
                return "Auto agregado";
            }
        }

        public string GetParkinInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Info del estacinamiento");

            for (int i = 0 ; i < listaAutos.Count; i++)
            {
                sb.AppendLine("Auto Numero" + (i + 1));
                sb.AppendLine("Patente: " + listaAutos[i].patente);
                sb.AppendLine("Color: " + listaAutos[i].color);
                sb.AppendLine("DNI Duenio: " + listaAutos[i].dniDuenio);
                sb.AppendLine(" ");
            }
            return sb.ToString();
        }
    }
}
