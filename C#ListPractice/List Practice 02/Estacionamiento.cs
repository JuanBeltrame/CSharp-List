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
            this.capacidadEstacionamiento = capacidad;
        }

        public int CapacidadEstacionamiento { get => capacidadEstacionamiento; set => capacidadEstacionamiento = value; }



        public string IngresarAuto(Auto auxAuto)
        {
            if (capacidadEstacionamiento >= listaAutos.Count())
            {
                return "Error, Estacionamiento Completo";
            }
            else
            {
                listaAutos.Add(auxAuto);
                return "Auto agregado";
            }
        }
    }
}
