using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string CiudadOrigen { get; set; }

        public string Entrenador { get; set; }
        public List<Jugador> Jugadores { get; set; }

        public Equipo()
        {
            Nombre = "Fagds";
            CiudadOrigen = "Navojoa";
            Entrenador = "Alexia Ruiz";
            Jugadores = new List<Jugador>();
        }

        public Equipo(string nombre)
        {
            Nombre = nombre;
            CiudadOrigen = "Navojoa";
            Entrenador = "Alexia Ruiz";
            Jugadores = new List<Jugador>();
        }
    }
}
