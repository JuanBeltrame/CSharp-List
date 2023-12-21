using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice_05__Library_
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        public Equipo()
        {
              jugadores = new List<Jugador>();  
        }


        public Equipo(string nombre, short cantidadDeJugadores) : this()
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidadDeJugadores;
        }

        public static bool operator + (Equipo equipo, Jugador jugador)
        {
            if (equipo.jugadores.Count < equipo.cantidadDeJugadores)
            {
                foreach (Jugador jug in equipo.jugadores)
                {
                    if (jug == jugador)
                    {
                        return true;
                    }
                }
                equipo.jugadores.Add(jugador);
                return true;
            }
        }
    }
}
