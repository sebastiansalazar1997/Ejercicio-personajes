﻿using System;
using System.Collections.Generic;
using System.IO;
using Entidades;

namespace Interfaces
{
    public class IPersistencia4
    {
        public bool Grabar(Jugador jugador)
        {
            File.AppendAllLines("Jugador.txt", new List<string> { jugador.Player4 });
            Console.WriteLine("EL jugador: " + jugador.Player4);
            return true;
        }
        public bool Grabar(Acciones acciones)
        {
            File.AppendAllLines("Acciones.txt", new List<string> { acciones.Accion4 });
            Console.WriteLine("Con el fin de: " + acciones.Accion4);
            return true;
        }
        public bool Grabar(Arma arma)
        {
            File.AppendAllLines("Arma.txt", new List<string> { arma.Arma4 });
            Console.WriteLine("Usa el arma: " + arma.Arma4);
            return true;
        }
        public bool Grabar(AccionDeJugador acciondejugador)
        {
            File.AppendAllLines("AccionDeJugador.txt", new List<string> { acciondejugador.ToString() });
            return true;
        }
    }
}
