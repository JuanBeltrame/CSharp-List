using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace List_Practice_05__Library_
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioDeGoles;
        private int totalGoles;

        public Jugador()
        {
            dni = default;
            partidosJugados = default;
            promedioDeGoles = default;
            totalGoles = default;
        }

        public Jugador(int dni, string nombre)
            :this()
        {
            this.dni = dni;
            this.nombre = nombre; 
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            :this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            if (partidosJugados == 0)
            {
                return 0;
            }

            promedioDeGoles = (float)totalGoles / partidosJugados;
            return promedioDeGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Cantidad de partidos jugados: {dni}");
            sb.AppendLine($"Total Goles: {totalGoles}");
            sb.AppendLine($"Promedio Goles: {GetPromedioGoles()}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador jugaro01, Jugador jugador02)
        {
            if (jugaro01 is not null && jugador02 is not null)
            {
                return jugaro01.dni == jugador02.dni;
            }
            return false;
        }

        public static bool operator !=(Jugador jugaro01, Jugador jugador02)
        {
            
            return !(jugaro01 == jugador02);
        }
    }
}
