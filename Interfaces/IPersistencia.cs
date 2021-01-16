using Entidades;
using System;
using System.Collections.Generic;
using System.IO;

namespace Interfaces
{
    public interface IPersistencia
    {
        public bool Grabar(Jugador jugador)
        {
            File.AppendAllLines("Jugador.txt", new List<string> { jugador.Player1 });
            Console.WriteLine("El jugador: " + jugador.Player1);
            return true;
        }
        public bool Grabar(Acciones acciones)
        {
            File.AppendAllLines("Acciones.txt", new List<string> { acciones.Accion1 });
            Console.WriteLine("Con el fin de: " + acciones.Accion1);
            return true;
        }
        public bool Grabar(Arma arma)
        {
            File.AppendAllLines("Arma.txt", new List<string> { arma.Arma1 });
            Console.WriteLine("Con el fin de: " + arma.Arma1);
            return true;
        }
        public bool Grabar(AccionDeJugador acciondejugador)
        {
            File.AppendAllLines("AccionDeJugador.txt", new List<string> { acciondejugador.ToString() });
            return true;
        }

    }
}
