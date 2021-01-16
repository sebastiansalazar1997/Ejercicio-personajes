using System;
using System.Collections.Generic;
using System.IO;
using Entidades;

namespace Interfaces
{
    public class IPersistencia2
    {
        public bool Grabar(Jugador jugador)
        {
            File.AppendAllLines("Jugador.txt", new List<string> { jugador.Player2 });
            Console.WriteLine("EL jugador: " + jugador.Player2);
            return true;
        }
        public bool Grabar(Acciones acciones)
        {
            File.AppendAllLines("Acciones.txt", new List<string> { acciones.Accion2 });
            Console.WriteLine("Con el fin de: " + acciones.Accion2);
            return true;
        }
        public bool Grabar(Arma arma)
        {
            File.AppendAllLines("Arma.txt", new List<string> { arma.Arma2 });
            Console.WriteLine("Usa el arma: " + arma.Arma2);
            return true;
        }
        public bool Grabar(AccionDeJugador acciondejugador)
        {
            File.AppendAllLines("AccionDeJugador.txt", new List<string> { acciondejugador.AccionId.ToString() });
            return true;
        }
    }
}
