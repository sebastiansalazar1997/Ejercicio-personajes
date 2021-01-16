using System;
using System.Collections.Generic;
using System.IO;
using Entidades;
using Interfaces;

namespace PersistenciaTres
{
    public class Persistencia3 : IPersistencia3
    {
        public new bool Grabar(Jugador jugador)
        {
            File.AppendAllLines("Jugador.txt", new List<string> { jugador.Player3 });
            Console.WriteLine("EL jugador: " + jugador.Player3);
            return true;
        }
        public new bool Grabar(Acciones acciones)
        {
            File.AppendAllLines("Acciones.txt", new List<string> { acciones.Accion3 });
            Console.WriteLine("Con el fin de: " + acciones.Accion3);
            return true;
        }
        public new bool Grabar(Arma arma)
        {
            File.AppendAllLines("Arma.txt", new List<string> { arma.Arma3 });
            Console.WriteLine("Usa el arma: " + arma.Arma3);
            return true;
        }
        public new bool Grabar(AccionDeJugador acciondejugador)
        {
            File.AppendAllLines("AccionDeJugador.txt", new List<string> { acciondejugador.AccionId.ToString() });
            return true;
        }
    }

}
