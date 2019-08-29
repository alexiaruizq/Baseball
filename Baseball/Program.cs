using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos =
                 new List<Equipo>();
            Equipo mayos = new Equipo("Mayos");
            mayos.Entrenador = "Alexia";
            mayos.CiudadOrigen = "Navoyork";

            mayos.Jugadores.Add(new Jugador("Aileen Balderrama", 5));
            mayos.Jugadores.Add(new Jugador("Gabriel Pereda", 17));
            mayos.Jugadores.Add(new Jugador("Alexia Ruiz", 7));
            mayos.Jugadores.Add(new Jugador("Raul Campbell", 33));
            mayos.Jugadores.Add(new Jugador("Iguana Yovana", 23));
            mayos.Jugadores.Add(new Jugador("Fatima Millanes", 90));


            Equipo yaquis = new Equipo("Yaquis");
            yaquis.Entrenador = "Pedrou";
            yaquis.CiudadOrigen = "Obre";

            yaquis.Jugadores.Add(new Jugador("J1", 9));
            yaquis.Jugadores.Add(new Jugador("J2", 8));
            yaquis.Jugadores.Add(new Jugador("J3", 6));
            yaquis.Jugadores.Add(new Jugador("J4", 5));
            yaquis.Jugadores.Add(new Jugador("J5", 4));


            equipos.Add(mayos);
            equipos.Add(yaquis);

            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("*" + equipo.Nombre + " de " + equipo.CiudadOrigen);

            foreach(Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("-" + jugador.Nombre + " " + jugador.Numero);
                }
            }

            Console.Read();
        }

        
    }
}
