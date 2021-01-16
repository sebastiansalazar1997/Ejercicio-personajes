using System;
using System.Collections.Generic;
using System.IO;
using Entidades;
using Interfaces;

namespace PersistenciaDos
{
    public class Persistencia2 : IPersistencia2
    {
        public new bool Grabar(Jugador jugador)
        {
            File.AppendAllLines("Jugador.txt", new List<string> { jugador.Player2 });
            Console.WriteLine("EL jugador: " + jugador.Player2);
            return true;
        }
        public new bool Grabar(Acciones acciones)
        {
            File.AppendAllLines("Acciones.txt", new List<string> { acciones.Accion2 });
            Console.WriteLine("Con el fin de: " + acciones.Accion2);
            return true;
        }
        public new bool Grabar(Arma arma)
        {
            File.AppendAllLines("Nivel.txt", new List<string> { arma.Arma2 });
            Console.WriteLine("Usa el arma: " + arma.Arma2);
            return true;
        }
        public new bool Grabar(AccionDeJugador acciondejugador)
        {
            File.AppendAllLines("AccionDeJugador.txt", new List<string> { acciondejugador.AccionId.ToString() });
            return true;
        }
    }

}
