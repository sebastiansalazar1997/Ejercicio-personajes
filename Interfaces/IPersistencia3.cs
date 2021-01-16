using Entidades;
using System;
using System.Collections.Generic;
using System.IO;

namespace Interfaces
{
    public class IPersistencia3
    {
        public bool Grabar(Jugador jugador)
        {
            File.AppendAllLines("Jugador.txt", new List<string> { jugador.Player3 });
            Console.WriteLine("EL jugador: " + jugador.Player3);
            return true;
        }
        public bool Grabar(Acciones acciones)
        {
            File.AppendAllLines("Acciones.txt", new List<string> { acciones.Accion3 });
            Console.WriteLine("Con el fin de: " + acciones.Accion3);
            return true;
        }
        public bool Grabar(Arma arma)
        {
            File.AppendAllLines("Arma.txt", new List<string> { arma.Arma3 });
            Console.WriteLine("Usa el arma: " + arma.Arma3);
            return true;
        }
        public bool Grabar(AccionDeJugador acciondejugador)
        {
            File.AppendAllLines("AccionDeJugador.txt", new List<string> { acciondejugador.ToString() });
            return true;
        }
    }
}
