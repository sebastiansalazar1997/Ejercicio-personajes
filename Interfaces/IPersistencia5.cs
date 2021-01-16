using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Entidades;

namespace Interfaces
{
    public class IPersistencia5
    {
        public bool Grabar(Jugador jugador)
        {
            File.AppendAllLines("Jugador.txt", new List<string> { jugador.Player5 });
            Console.WriteLine("EL jugador: " + jugador.Player5);
            return true;
        }
        public bool Grabar(Acciones acciones)
        {
            File.AppendAllLines("Acciones.txt", new List<string> { acciones.Accion5 });
            Console.WriteLine("Con el fin de " + acciones.Accion5);
            return true;
        }
        public bool Grabar(Arma arma)
        {
            File.AppendAllLines("Arma.txt", new List<string> { arma.Arma5 });
            Console.WriteLine("Usa el arma " + arma.Arma5);
            return true;
        }
        public bool Grabar(AccionDeJugador acciondejugador)
        {
            File.AppendAllLines("AccionDeJugador.txt", new List<string> { acciondejugador.ToString() });
            return true;
        }
    }
}
